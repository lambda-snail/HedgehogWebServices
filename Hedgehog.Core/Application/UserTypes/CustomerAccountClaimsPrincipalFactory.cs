using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Hedgehog.Core.Application.UserTypes
{
    /// <summary>
    /// Adds application specific claims to the Customer class. The following claim is added:
    /// "WebStoreNavigationTitle" - the navigation string of the associated web store.
    /// </summary>
    public class CustomerAccountClaimsPrincipalFactory : UserClaimsPrincipalFactory<CustomerAccount>
    {
        public CustomerAccountClaimsPrincipalFactory(
            UserManager<CustomerAccount> userManager,
            IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, optionsAccessor)
        {}

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(CustomerAccount customer)
        {
            var identity = await base.GenerateClaimsAsync(customer);
            identity.AddClaim(new Claim("WebStoreNavigationTitle", customer.WebStore.NavigationTitle ?? "[Click to edit profile]"));
            return identity;
        }
    }
}
