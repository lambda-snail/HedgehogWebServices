using Hedgehog.Core.Application;
using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    public class CreateOrderRequest : IRequest<Order>
    {
        public ShoppingCart Cart { get; set; }
        public Address Address { get; set; }
        public CustomerAccount Customer { get; set; }

        /// <summary>
        /// Should the resulting order be saved to the database when created?
        /// Defaults to false.
        /// </summary>
        public bool SaveToDatabase { get; set; } = false;
    }
}
