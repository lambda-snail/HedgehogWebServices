using MediatR;
using Hedgehog.Core.Contracts;
using Hedgehog.Core.Domain.Requests;
using System.Threading;
using System.Threading.Tasks;
using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;

namespace Hedgehog.Core.Domain.Commands
{
    class TestServiceRequestHandler : IRequestHandler<TestServiceRequest, ITestService>
    {
        private ITestRepository _repo;
        public TestServiceRequestHandler(ITestRepository repo)
        {
            _repo = repo;
        }
        public async Task<ITestService> Handle(TestServiceRequest request, CancellationToken cancellationToken)
        {
            return _repo.GetTestService("Hello MediatR World");
        }
    }
}
