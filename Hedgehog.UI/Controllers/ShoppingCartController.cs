using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Hedgehog.Core.Application.Requests;
using Hedgehog.UI.ViewModels;
using Hedgehog.Core.Domain;
using Hedgehog.Core.Domain.Requests;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Hedgehog.Core.Application;

namespace Hedgehog.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMediator _mediator;
        private readonly UserManager<CustomerAccount> _userManager;
        private readonly ShoppingCart _cart;
        //private readonly ISession _session;

        // Use this when querying the ISession for the cart data
        private readonly string _CartKey = "Cart";

        public ShoppingCartController(IMediator mediator, UserManager<CustomerAccount> userManager, ShoppingCart cart)
        {
            _mediator = mediator;
            _userManager = userManager;
            _cart = cart;
        }

        // Retreieve the current cart stored in the session, or create a new cart if
        // no such cart exists.
        private async Task<ShoppingCart> GetCurrentShoppingCartOrNew(string storeNavigationTitle)
        {
            ISession session = HttpContext.Session;
            string cartJson = session.GetString(_CartKey);
            ShoppingCart cart = null;
            if (!string.IsNullOrEmpty(cartJson))
            {
                // There might be a better way than deserializing before adding, but it works for now
                cart = await _mediator.Send(new DeserializeShoppingCartRequest { Json = cartJson });
            }

            if (cart == null)
            {
                cart = _cart;
                WebStore store = await _mediator.Send(new GetStoreFromNavigationTitleRequest { NavigationTitle = storeNavigationTitle });
                cart.StoreId = store.WebStoreId;
            }

            return cart;
        }

        private async Task SaveShoppingCartToSession(ShoppingCart cart)
        {
            string jsonCart = await _mediator.Send(new SerializeShoppingCartRequest { Cart = cart });
            HttpContext.Session.SetString(_CartKey, jsonCart);
        }

        [Route("{storeNavigationTitle}/ShoppingCart/Index")]
        public async Task<IActionResult> Index(string storeNavigationTitle)
        {
            ShoppingCart cart = await GetCurrentShoppingCartOrNew(storeNavigationTitle);
            double total = await cart.CalculateTotal();
            return View(cart);
        }

        [Route("{storeNavigationTitle}/ShoppingCart/AddToCart")]
        public async Task<IActionResult> AddToCart(string storeNavigationTitle, int productId)
        {
            ShoppingCart cart = await GetCurrentShoppingCartOrNew(storeNavigationTitle);
            cart.AddToCart(productId);
            await SaveShoppingCartToSession(cart);
            return View();
        }

        // If the customer is entering the shopping cart from another store, we will redirect to
        // the corect store. The way the system is designed, it doesn't matter where the customer
        // enters the checkout process, but this behavior could potentially be confusing to customers.
        [Authorize(Roles = "Customer")]
        [Route("{storeNavigationTitle}/ShoppingCart/CheckoutAddressForm")]
        public async Task<IActionResult> CheckoutAddressForm(string storeNavigationTitle)
        {
            CustomerAccount customer = await _mediator.Send(new GetCustomerWithNavigationPropertiesRequest { UserId = User.FindFirstValue(ClaimTypes.NameIdentifier) });
            if(customer.WebStore.NavigationTitle == storeNavigationTitle)
            {
                return View();
            }
            else
            {
                return RedirectToAction("CheckoutAddressForm", "ShoppingCart", new { storeNavigationTitle= customer.WebStore.NavigationTitle });
            }
            
        }

        [HttpPost]
        [Authorize(Roles = "Customer")]
        [Route("{storeNavigationTitle}/ShoppingCart/CheckoutAddressForm")]
        public async Task<IActionResult> CheckoutAddressForm(string storeNavigationTitle, AddressViewModel addressVm)
        {
            if(ModelState.IsValid)
            {
                // We need to serialize the address since the default serializer will complain otherwise
                TempData["address"] = await _mediator.Send(new SerializeAddressRequest { Address= GetAddressFromVM(addressVm) });
                return RedirectToAction("CheckoutPaymentForm", new { storeNavigationTitle= storeNavigationTitle });
            }

            return View(addressVm);
        }

        private Address GetAddressFromVM(AddressViewModel avm)
        {
            Address address = new();

            address.AddressId = avm.AddressId;
            address.City = avm.City;
            address.Country = avm.Country;
            address.Receiver = avm.Recipient;
            address.ZipCode = avm.ZipCode;
            address.StreetAddress = avm.StreetAddress;

            return address;
        }

        [Authorize(Roles = "Customer")]
        [Route("{storeNavigationTitle}/ShoppingCart/CheckoutPaymentForm")]
        public async Task<IActionResult> CheckoutPaymentForm(string storeNavigationTitle)
        {
            ShoppingCart cart = await GetCurrentShoppingCartOrNew(storeNavigationTitle);
            CustomerAccount customer = await _mediator.Send(new GetCustomerWithNavigationPropertiesRequest { UserId = User.FindFirstValue(ClaimTypes.NameIdentifier) });
            WebStore store = customer.WebStore;
            Address orderAddress = await _mediator.Send( new DeserializeAddressRequest { Json= TempData["address"] as string } );

            Order order = await _mediator.Send(new CreateOrderRequest { SaveToDatabase = false, Cart = cart, Address = orderAddress, Customer = customer });

            PaymentSummaryViewModel paymentSummary = new();
            paymentSummary.Order = order;
            paymentSummary.WebStoreName = store.StoreTitle;

            return View(paymentSummary);
        }
    }
}
