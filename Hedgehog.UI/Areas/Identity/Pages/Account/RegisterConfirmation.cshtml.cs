using Microsoft.AspNetCore.Authorization;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Hedgehog.Core.Application;

namespace Hedgehog.UI.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterConfirmationModel : PageModel
    {
        private readonly UserManager<HedgehogUserAccount> _userManager;
        private readonly IUserTwoFactorTokenProvider<HedgehogUserAccount> _tokenProvider;
        private readonly IEmailSender _sender;

        public RegisterConfirmationModel(UserManager<HedgehogUserAccount> userManager,
                                         IUserTwoFactorTokenProvider<HedgehogUserAccount> tokenProvider,
                                         IEmailSender sender)
        {
            _userManager = userManager;
            _tokenProvider = tokenProvider;
            _sender = sender;
        }

        public string Email { get; set; }

        public bool DisplayConfirmAccountLink { get; set; }

        public string EmailConfirmationUrl { get; set; }

        public async Task<IActionResult> OnGetAsync(string email, string returnUrl = null)
        {
            if (email == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return NotFound($"Unable to load user with email '{email}'.");
            }

            Email = email;
            // Once you add a real email sender, you should remove this code that lets you confirm the account
            DisplayConfirmAccountLink = true;
            if (DisplayConfirmAccountLink)
            {
                var userId = await _userManager.GetUserIdAsync(user);

                _userManager.RegisterTokenProvider("Default", _tokenProvider);
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                EmailConfirmationUrl = Url.Page(
                    "/Account/ConfirmEmail",
                    pageHandler: null,
                    values: new { area = "Identity", userId = userId, code = code, returnUrl = returnUrl },
                    protocol: Request.Scheme);
            }

            return Page();
        }
    }
}
