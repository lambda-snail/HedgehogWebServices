using MediatR;
using System.Collections.Generic;

namespace Hedgehog.Core.Domain.Requests
{
    public class GetAllOrdersByCustomerIdRequest : IRequest<IEnumerable<Order>>
    {
        public string CustomerId { get; set; }
    }
}
