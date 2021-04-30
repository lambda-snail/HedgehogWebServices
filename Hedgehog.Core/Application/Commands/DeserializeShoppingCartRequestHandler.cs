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
        private readonly IMediator _mediator;

        public DeserializeShoppingCartRequestHandler(ISerializer<ShoppingCart> serializer, IMediator mediator)
        {
            _serializer = serializer;
            _mediator = mediator;
        }
        public async Task<ShoppingCart> Handle(DeserializeShoppingCartRequest request, CancellationToken cancellationToken)
        {
            return await _serializer.DeserializeAsync(request.Json);
        }
    }
}

