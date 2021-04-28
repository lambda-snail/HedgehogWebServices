using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    /// <summary>
    /// A request to add or update a web store in the system.
    /// </summary>
    public class AddOrUpdateStoreRequest : IRequest
    {
        public WebStore Store;
    }
}
