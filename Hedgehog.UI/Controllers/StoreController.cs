using MediatR;
using Microsoft.AspNetCore.Mvc;
using Hedgehog.Core.Domain.Requests;
using Hedgehog.Core.Domain;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using Hedgehog.UI.ViewModels;

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

        //[Route("{storeNavigationTitle}/Store/Index")]
        public async Task<IActionResult> Index(string storeNavigationTitle)
        {
            WebStore store =  await _mediator.Send( new GetStoreFromNavigationTitleRequest { NavigationTitle = storeNavigationTitle } );
            
            if(store == null)
            {
                return NotFound();
            }
            
            IEnumerable<Product> products = await _mediator.Send( new GetProductsFromStoreRequest { StoreId = store.WebStoreId } );
            ViewBag.Message = store.StoreTitle;
            ViewBag.StoreDescription = store.StoreDescription ?? "No description added by the owner yet.";
            ViewBag.NumItems = products.Count();
            return View(products);
        }

        [Route("{storeNavigationTitle}/Store/Details")]
        public async Task<IActionResult> Details(string storeNavigationTitle, int productId)
        {
            WebStore store = await _mediator.Send(new GetStoreFromNavigationTitleRequest { NavigationTitle = storeNavigationTitle });

            if (store == null)
            {
                return NotFound();
            }

            Product p = await _mediator.Send( new GetSingleProductFromStoreRequest { StoreId=store.WebStoreId, ProductId=productId } );

            if (p == null)
            {
                return NotFound();
            }

            ProductViewModel productVm = new();
            productVm.ProductName = p.ProductName;
            productVm.ShortDescription = p.ShortDescription;
            productVm.LongDescription = p.LongDescription;
            productVm.ImageUrl = p.ImageUrl;
            productVm.Price = p.Price;

            ViewBag.ProductId = p.ProductId;

            return View(productVm);
        }
    }
}
