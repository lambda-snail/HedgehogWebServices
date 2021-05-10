using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    public class GetOrderByIdRequest : IRequest<Order>
    {
        public int OrderId { get; set; }
    }
}
