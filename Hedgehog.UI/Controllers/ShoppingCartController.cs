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

namespace Hedgehog.UI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IShoppingCart _cart;
        //private readonly ISession _session;

        // Use this when querying the ISession for the cart data
        private readonly string _CartKey = "Cart";

        public ShoppingCartController(IMediator mediator, IShoppingCart cart)
        {
            _mediator = mediator;
            _cart = cart;
        }

        [Route("{storeNavigationTitle}/ShoppingCart/Index")]
        public async Task<IActionResult> Index(string storeNavigationTitle)
        {
            ISession session = HttpContext.Session;
            string cartJson = session.GetString(_CartKey);
            IShoppingCart cart = null;
            if (!string.IsNullOrEmpty(cartJson))
            {
                // There might be a better way than deserializing before adding, but it works for now
                cart = await _mediator.Send(new DeserializeShoppingCartRequest { Json = cartJson });
            }

            double total = await cart.CalculateTotal();

            return View(cart);
        }

        [Route("{storeNavigationTitle}/ShoppingCart/AddToCart")]
        public async Task<IActionResult> AddToCart(string storeNavigationTitle, int productId)
        {
            ISession session = HttpContext.Session;
            string cartJson = session.GetString(_CartKey);

            IShoppingCart cart = null;
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

            cart.AddToCart(productId);
            cartJson = await _mediator.Send(new SerializeShoppingCartRequest { Cart = (ShoppingCart)cart });
            session.SetString(_CartKey, cartJson);

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

        public async Task<IActionResult> CheckoutPaymentForm(string storeNavigationTitle)
        {
            return View();
        }
    }
}
