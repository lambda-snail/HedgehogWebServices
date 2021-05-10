using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    public class AddOrUpdateOrderRequest : IRequest
    {
        public Order Order { get; set; }
    }
}
