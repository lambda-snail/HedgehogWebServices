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
    /// <summary>
    /// A class for handling login, registration and settings pages of customers.
    /// 
    /// Note that the login and registration are adapted from the scaffolded Razor pages. This was done in orde
    /// to learn how they work, thus there is some duplication going on.
    /// </summary>
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
                if (result.Succeeded)
                {
                    _userManager.AddToRoleAsync(newUser, "Customer").Wait();

                    string returnUrl = Url.Content($"~");
                    //var code = "user-token" + registrationData.Email;//await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
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
                        return RedirectToAction("RegisterConfirmation", new { storeNavigationTitle = storeNavigationTitle, email = registrationData.Email, returnUrl = returnUrl });
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

        [Route("{storeNavigationTitle}/Customer/RegisterConfirmation")]
        public async Task<IActionResult> RegisterConfirmation(string storeNavigationTitle, string email, string returnUrl)
        {
            RegisterConfirmationViewModel confirmationData = new();

            if (email == null)
            {
                return RedirectToAction("Store", "Index", new { storeNavigationTitle= storeNavigationTitle });
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            confirmationData.Email = email;
            // Once you add a real email sender, you should remove this code that lets you confirm the account
            confirmationData.DisplayConfirmAccountLink = true;
            if (confirmationData.DisplayConfirmAccountLink)
            {
                var userId = await _userManager.GetUserIdAsync(user);
                //var code = "user-token" + email;//await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                confirmationData.EmailConfirmationUrl = Url.Action(
                    action: "ConfirmEmail",
                    controller: "Customer",
                    values: new { userId = userId, code = code, returnUrl = returnUrl, storeNavigationTitle = storeNavigationTitle },
                    protocol: Request.Scheme);
            }

            return View(confirmationData);
        }

        [Route("{storeNavigationTitle}/Customer/ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string storeNavigationTitle, string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToAction("Store", "Index", new { storeNavigationTitle });
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            //_userManager.RegisterTokenProvider("Default", new HedgehogEmailTwoFactorAuthentication<CustomerAccount>());

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            ViewBag.StatusMessage = result.Succeeded ? "Thank you for confirming your email." : "Error confirming your email.";
            return View();
        }
    }
}
