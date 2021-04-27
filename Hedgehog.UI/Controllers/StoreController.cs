using MediatR;
using Microsoft.AspNetCore.Mvc;
using Hedgehog.Core.Domain.Requests;
using Hedgehog.Core.Domain;
using System.Threading.Tasks;

namespace Hedgehog.UI.Controllers
{
    /// <summary>
    /// This controller handles the presentation of a web store.
    /// </summary>
    public class StoreController : Controller
    {
        private readonly IMediator _mediator;
        
        public StoreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index(string storeNavigationTitle)
        {
            WebStore store =  await _mediator.Send( new GetStoreFromNavigationTitleRequest { NavigationTitle = storeNavigationTitle } );
            ViewBag.Message = store.StoreTitle;
            return View();
        }
    }
}
