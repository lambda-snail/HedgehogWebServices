using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    /// <summary>
    /// The Domain.Requests namespace contains all request objects that are tied to request handlers in Domain.Command.
    /// </summary>
    public class AddOrUpdateOrderRequest : IRequest
    {
        public Order Order { get; set; }
    }
}
