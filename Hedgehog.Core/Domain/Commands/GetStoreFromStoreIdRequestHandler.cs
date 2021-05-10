using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    public class GetStoreFromStoreIdRequestHandler : IRequestHandler<GetStoreFromStoreIdRequest, WebStore>
    {
        private readonly IAsyncGenericRepository<WebStore, int> _storeRepository;

        public GetStoreFromStoreIdRequestHandler(IAsyncGenericRepository<WebStore, int> storeRepository)
        {
            _storeRepository = storeRepository;
        }

        public async Task<WebStore> Handle(GetStoreFromStoreIdRequest request, CancellationToken cancellationToken)
        {
            return await _storeRepository.GetByIdAsync(request.StoreId);
        }
    }
}
