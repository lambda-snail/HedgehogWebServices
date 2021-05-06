using MediatR;

namespace Hedgehog.Core.Application.Requests
{
    /// <summary>
    /// The built-in UserManager does not load navigation properties. This class makes a request
    /// to ensure that these are loaded, and should be used when needed. If not needed, the normal
    /// way to get user information via UserManager is preferred.
    /// </summary>
    public class GetCustomerWithNavigationPropertiesRequest : IRequest<CustomerAccount>
    {
        public string UserId { get; set; }
    }
}
