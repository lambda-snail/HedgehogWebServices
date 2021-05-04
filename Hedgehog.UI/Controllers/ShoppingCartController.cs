using Hedgehog.Core.Contracts.DomainContracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Http;
using Hedgehog.Core.Application.Requests;
using Hedgehog.UI.ViewModels;
using Hedgehog.Core.Domain;
using Hedgehog.Core.Domain.Requests;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Hedgehog.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMediator _mediator;
        private readonly ShoppingCart _cart;
        //private readonly ISession _session;

        // Use this when querying the ISession for the cart data
        private readonly string _CartKey = "Cart";

        public ShoppingCartController(IMediator mediator, ShoppingCart cart)
        {
            _mediator = mediator;
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

        [Route("{storeNavigationTitle}/ShoppingCart/CheckoutAddressForm")]
        public async Task<IActionResult> CheckoutAddressForm(string storeNavigationTitle)
        {
            return View();
        }

        [HttpPost]
        [Route("{storeNavigationTitle}/ShoppingCart/CheckoutAddressForm")]
        public async Task<IActionResult> CheckoutAddressForm(string storeNavigationTitle, AddressViewModel addressVm)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("CheckoutPaymentForm", new { storeNavigationTitle= storeNavigationTitle });
            }

            return View(addressVm);
        }

        [Authorize(Roles = "Customer")]
        public async Task<IActionResult> CheckoutPaymentForm(string storeNavigationTitle)
        {
            ShoppingCart cart = await GetCurrentShoppingCartOrNew(storeNavigationTitle);
            WebStore store = await _mediator.Send(new GetStoreFromUserIdRequest { UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value });

            PaymentSummaryViewModel paymentSummary = new();
            paymentSummary.TotalAmount = await cart.CalculateTotal();

            return View(paymentSummary);
        }
    }
}
