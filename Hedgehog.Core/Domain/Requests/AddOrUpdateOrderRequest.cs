using MediatR;

/// <summary>
/// The Domain.Requests namespace contains all request objects that are tied to request handlers in Domain.Command.
/// </summary>
namespace Hedgehog.Core.Domain.Requests
{
    public class AddOrUpdateOrderRequest : IRequest
    {
        public Order Order { get; set; }
    }
}
