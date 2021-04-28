using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    class AddOrUpdateStoreRequestHandler : IRequestHandler<AddOrUpdateStoreRequest>
    {
        private readonly IWebStoreRepository _repository;
        public AddOrUpdateStoreRequestHandler(IWebStoreRepository repository)
        {
            _repository = repository;
        }
        public async Task<Unit> Handle(AddOrUpdateStoreRequest request, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(request.Store);
            return Unit.Value;
        }
    }
}
