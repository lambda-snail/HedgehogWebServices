using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    class AddOrUpdateProductRequestHandler : IRequestHandler<AddOrUpdateProductRequest>
    {
        private readonly IProductRepository _productRepository;
        public AddOrUpdateProductRequestHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<Unit> Handle(AddOrUpdateProductRequest request, CancellationToken cancellationToken)
        {
            await _productRepository.UpdateAsync(request.Product);
            return Unit.Value;
        }
    }
}
