using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hedgehog.Core.Application;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;

namespace Hedgehog.UI.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ConfirmEmailModel : PageModel
    {
        private readonly UserManager<UserAccount> _userManager;
        private readonly IUserTwoFactorTokenProvider<UserAccount> _tokenProvider;

        public ConfirmEmailModel(UserManager<UserAccount> userManager, IUserTwoFactorTokenProvider<UserAccount> tokenProvider)
        {
            _userManager = userManager;
            _tokenProvider = tokenProvider;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGetAsync(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return RedirectToPage("/Index");
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userId}'.");
            }

            _userManager.RegisterTokenProvider("Default", _tokenProvider);

            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await _userManager.ConfirmEmailAsync(user, code);
            StatusMessage = result.Succeeded ? "Thank you for confirming your email." : "Error confirming your email.";
            return Page();
        }
    }
}
