using Hedgehog.Core.Application.Requests;
using Hedgehog.Core.Domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Hedgehog.UI.Components
{
    /// <summary>
    /// Adapted from Gill Cleerens course. Displays a clickable shopping cart icon if there are items in the shopping cart.
    /// </summary>
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMediator _mediator;

        public ShoppingCartSummary(IHttpContextAccessor httpContextAccessor, IMediator mediator)
        {
            _httpContextAccessor = httpContextAccessor;
            _mediator = mediator;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            string cartJson = _httpContextAccessor.HttpContext.Session.GetString("Cart");
            ShoppingCart cart = null;
            if (!string.IsNullOrEmpty(cartJson))
            {
                // There might be a better way than deserializing before adding, but it works for now
                cart = await _mediator.Send(new DeserializeShoppingCartRequest { Json = cartJson });
            }

            return View(cart);
        }
    }
}
