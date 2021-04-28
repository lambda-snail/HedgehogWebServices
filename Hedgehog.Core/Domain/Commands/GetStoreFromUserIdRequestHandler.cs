using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    public class GetStoreFromUserIdRequestHandler : IRequestHandler<GetStoreFromUserIdRequest, WebStore>
    {
        private readonly IWebStoreRepository _repository;

        public GetStoreFromUserIdRequestHandler(IWebStoreRepository repository)
        {
            _repository = repository;
        }
        public async Task<WebStore> Handle(GetStoreFromUserIdRequest request, CancellationToken cancellationToken)
        {
            return await _repository.GetWebStoreFromUser(request.UserId);
        }
    }
}
