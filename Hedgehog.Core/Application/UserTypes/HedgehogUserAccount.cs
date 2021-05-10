using Hedgehog.Core.Domain;
using Microsoft.AspNetCore.Identity;

namespace Hedgehog.Core.Application
{
    /// <summary>
    /// Base class for user accounts in the application. 
    /// Customers and users of the service will have a link to the related web store.
    /// Administrators will not be related to a store.
    /// </summary>
    public abstract class HedgehogUserAccount : IdentityUser
    {
    }
}
