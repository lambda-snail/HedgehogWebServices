using Hedgehog.Core.Application;
using Hedgehog.Core.Domain;
using Hedgehog.Core.Domain.Requests;
using Hedgehog.UI.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Hedgehog.UI.Views.Store
{
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;
        private readonly UserManager<CustomerAccount> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<HedgehogUserAccount> _signInManager;
        private readonly IEmailSender _emailSender;

        public CustomerController(IMediator mediator,
                                  UserManager<CustomerAccount> userManager,
                                  RoleManager<IdentityRole> roleManager,
                                  SignInManager<HedgehogUserAccount> signInManager,
                                  IEmailSender emailSender)
        {
            _mediator = mediator;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        [AllowAnonymous]
        [Route("{storeNavigationTitle}/Customer/CreateCustomer")]
        public IActionResult CreateCustomer(string storeNavigationTitle)
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("{storeNavigationTitle}/Customer/CreateCustomer")]
        public async Task<IActionResult> CreateCustomer(string storeNavigationTitle, CreateCustomerViewModel registrationData)
        {
            WebStore store = await _mediator.Send(new GetStoreFromNavigationTitleRequest { NavigationTitle = storeNavigationTitle });
            if(store == null)
            {
                ModelState.AddModelError("", "Could not identify the web store. Please make sure that you register from an existing store.");
            }

            if (ModelState.IsValid)
            {
                CustomerAccount newUser = new();
                newUser.Email = registrationData.Email;
                newUser.UserName = registrationData.Email;
                newUser.WebStore = store;

                IdentityResult result = _userManager.CreateAsync(newUser, registrationData.Password).Result;
                if(result.Succeeded)
                {
                    _userManager.AddToRoleAsync(newUser, "Customer").Wait();

                    string returnUrl = Url.Content("~/");
                    var code = "user-token";//await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                    code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { area = "Identity", userId = newUser.Id, code = code, returnUrl = returnUrl },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(registrationData.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("/RegisterConfirmation", new { email = registrationData.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(newUser, isPersistent: false);
                        return RedirectToAction("Index", "Store", new { storeNavigationTitle = storeNavigationTitle });
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Unable to create user!");
                }

            }

            return View(registrationData);
        }
    }
}
