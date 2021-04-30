using Hedgehog.Core.Application.Requests;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using Hedgehog.Core.Domain;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Application.Commands
{
    public class DeserializeShoppingCartRequestHandler : IRequestHandler<DeserializeShoppingCartRequest, ShoppingCart>
    {
        private readonly ISerializer<ShoppingCart> _serializer;

        public DeserializeShoppingCartRequestHandler(ISerializer<ShoppingCart> serializer)
        {
            _serializer = serializer;
        }
        public async Task<ShoppingCart> Handle(DeserializeShoppingCartRequest request, CancellationToken cancellationToken)
        {
            return await _serializer.DeserializeAsync(request.Json);
        }
    }
}

