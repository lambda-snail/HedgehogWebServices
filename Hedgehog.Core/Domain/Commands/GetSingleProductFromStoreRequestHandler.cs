using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    public class GetSingleProductFromStoreRequestHandler : IRequestHandler<GetSingleProductFromStoreRequest, Product>
    {
        private readonly IProductRepository _repository;

        public GetSingleProductFromStoreRequestHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Product> Handle(GetSingleProductFromStoreRequest request, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsynch(request.ProductId);
        }
    }
}
