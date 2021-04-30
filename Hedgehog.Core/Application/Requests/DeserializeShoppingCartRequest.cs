using Hedgehog.Core.Domain;
using MediatR;

namespace Hedgehog.Core.Application.Requests
{
    public class DeserializeShoppingCartRequest : IRequest<ShoppingCart>
    {
        public string Json { get; set; }
    }
}
