using Hedgehog.Core.Domain;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hedgehog.UI.Controllers
{
    /// <summary>
    /// Handles logic related to store owners changing their data.
    /// </summary>
    public class UserSetupController : Controller
    {
        private readonly IMediator _mediator;

        public UserSetupController(IMediator mediator)
        {
            _mediator = mediator;
        }

        private string GetIdLoggedInUser()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        [Authorize]
        [Route("/User/Store")]
        public async Task<IActionResult> EditStoreForm()
        {
            var userId = GetIdLoggedInUser();
            WebStore store = await _mediator.Send(new GetStoreFromUserIdRequest { UserId = userId });

            return View(store);
        }

        // TODO:
        // USE A VIEW MODEL WITH JUST THE RIGHT DATA AND THEN GET FROM DB, AND UPDATE

        [Authorize]
        [Route("/User/Store")]
        [HttpPost]
        public async  Task<IActionResult> EditStoreForm(WebStore store)
        {
            if(string.IsNullOrWhiteSpace(store.StoreTitle))
            {
                ModelState.AddModelError("", "You must have a title for your store!");
            }
            if (string.IsNullOrWhiteSpace(store.NavigationTitle))
            {
                ModelState.AddModelError("", "You must have a navigation title for your store!");
            }

            if(ModelState.IsValid)
            {
                string userId = store.HedgehogUserAccountForeignKey = GetIdLoggedInUser();
                WebStore storeToSave = await _mediator.Send(new GetStoreFromUserIdRequest { UserId = userId });

                if(storeToSave == null) // Newly registered user
                {
                    storeToSave = store;
                    storeToSave.HedgehogUserAccountForeignKey = userId;
                }
                else
                {
                    storeToSave.NavigationTitle = store.NavigationTitle;
                    storeToSave.StoreTitle = store.StoreTitle;
                }

                await _mediator.Send( new AddOrUpdateStoreRequest { Store = storeToSave } );

                // Save changes here
                return RedirectToAction("ChangesSaved");
            }
            else
            {
                return View(store);
            }
        }


        [Authorize]
        [Route("/User/Confirmed")]
        public IActionResult ChangesSaved()
        {
            return View();
        }
    }
}
