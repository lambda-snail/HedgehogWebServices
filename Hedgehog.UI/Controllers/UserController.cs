using Hedgehog.Core.Application;
using Hedgehog.Core.Domain;
using Hedgehog.Core.Domain.Requests;
using Hedgehog.UI.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hedgehog.UI.Controllers
{
    /// <summary>
    /// Handles logic related to store owners changing their data.
    /// </summary>
    public class UserController : Controller
    {
        private readonly IMediator _mediator;
        private readonly UserManager<UserAccount> _userManager;

        public UserController(IMediator mediator, UserManager<UserAccount> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }

        private string GetIdLoggedInUser()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        [Authorize(Roles = "User")]
        [Route("/User/Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.UserName = User.Identity.Name;
            return View();
        }

        [Authorize(Roles = "User")]
        [Route("/User/Store")]
        public async Task<IActionResult> EditStoreForm()
        {
            var userId = GetIdLoggedInUser();
            WebStore store = await _mediator.Send(new GetStoreFromUserIdRequest { UserId = userId });

            WebStoreViewModel storeVm = new();
            storeVm.StoreTitle = store.StoreTitle;
            storeVm.NavigationTitle = store.NavigationTitle;
            //storeVm.StoreDescription

            return View(storeVm);
        }

        [Authorize(Roles = "User")]
        [Route("/User/Store")]
        [HttpPost]
        public async  Task<IActionResult> EditStoreForm(WebStoreViewModel storeVm)
        {
            if(ModelState.IsValid)
            {
                string userId = GetIdLoggedInUser();
                WebStore storeToSave = await _mediator.Send(new GetStoreFromUserIdRequest { UserId = userId });

                if(storeToSave == null) // Newly registered user
                {

                    storeToSave = new();
                    storeToSave.UserAccount = await _userManager.GetUserAsync(User);
                }
                
                storeToSave.NavigationTitle = storeVm.NavigationTitle;
                storeToSave.StoreTitle = storeVm.StoreTitle;
                //storeToSave.StoreDescription = storeVm.StoreDescription;

                await _mediator.Send( new AddOrUpdateStoreRequest { Store = storeToSave } );

                // Save changes here
                return RedirectToAction("ChangesSaved");
            }
            else
            {
                return View(storeVm);
            }
        }

        [Authorize(Roles = "User")]
        [Route("/User/Products")]
        public async Task<IActionResult> AddProductForm()
        {
            return View();
        }

        [Authorize(Roles = "User")]
        [Route("/User/Products")]
        [HttpPost]
        public async Task<IActionResult> AddProductForm(ProductViewModel product)
        {
            if(product.Price < 0)
            {
                ModelState.AddModelError("", "Please enter a price that is not negative.");
            }

            if(ModelState.IsValid)
            {
                string userId = GetIdLoggedInUser();
                WebStore store = await _mediator.Send(new GetStoreFromUserIdRequest { UserId = userId });

                Product newProduct = new Product
                {
                    ProductName = product.ProductName,
                    ShortDescription = product.ShortDescription,
                    LongDescription = product.LongDescription,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    WebStore = store,
                    WebStoreId = store.WebStoreId
                };

                await _mediator.Send(new AddOrUpdateProductRequest { Product = newProduct });

                return RedirectToAction("ChangesSaved");
            }
            else
            {
                return View(product);
            }
        }


        [Authorize(Roles = "User")]
        [Route("/User/Confirmed")]
        public IActionResult ChangesSaved()
        {
            return View();
        }
    }
}
