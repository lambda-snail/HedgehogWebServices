using Hedgehog.Core.Application.Requests;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using Hedgehog.Core.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Application.Commands
{
    public class SerializeShoppingCartRequestHandler : IRequestHandler<SerializeShoppingCartRequest, string>
    {
        private readonly ISerializer<ShoppingCart> _serializer;

        public SerializeShoppingCartRequestHandler(ISerializer<ShoppingCart> serializer)
        {
            _serializer = serializer;
        }
        public async Task<string> Handle(SerializeShoppingCartRequest request, CancellationToken cancellationToken)
        {
            return await _serializer.SerializeAsync(request.Cart);
        }
    }
}

