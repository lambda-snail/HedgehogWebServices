using Hedgehog.Core.Application;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Hedgehog.UI.IdentityInfrastructure
{
    /// <summary>
    /// Generates two-factor authentication tokens. The tokens are functions of the userid, the email and also
    /// the purpose of the token.
    /// </summary>
    public class HedgehogEmailTwoFactorAuthentication<TUser> : IUserTwoFactorTokenProvider<TUser> where TUser : HedgehogUserAccount
    {
        public Task<bool> CanGenerateTwoFactorTokenAsync(UserManager<TUser> manager, TUser user)
        {
            if (manager != null && user != null)
            {
                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        // Genereates a simple token based on the user id, email and another string.
        private string GenerateToken(HedgehogUserAccount user, string purpose)
        {
            string secretString = "coffeIsGood";
            return secretString + user.Email + purpose + user.Id;
        }

        public Task<string> GenerateAsync(string purpose, UserManager<TUser> manager, TUser user)
        {
            return Task.FromResult(GenerateToken(user, purpose));
        }

        public Task<bool> ValidateAsync(string purpose, string token, UserManager<TUser> manager, TUser user)
        {
            return Task.FromResult(token == GenerateToken(user, purpose));
        }
    }
}
