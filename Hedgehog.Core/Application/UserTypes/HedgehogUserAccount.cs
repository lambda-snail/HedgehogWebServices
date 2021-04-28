using Hedgehog.Core.Domain;
using Microsoft.AspNetCore.Identity;

namespace Hedgehog.Core.Application
{
    /// <summary>
    /// Customers and users of the service will have a link to the related web store.
    /// Administrators will not be related to a store.
    /// </summary>
    public class HedgehogUserAccount : IdentityUser
    {
        public WebStore WebStore { get; set; }
    }
}
