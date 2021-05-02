using Hedgehog.Core.Domain;
using MediatR;

namespace Hedgehog.Core.Application.Requests
{
    public class SerializeShoppingCartRequest : IRequest<string>
    {
        public ShoppingCart Cart { get; set; }
    }
}
