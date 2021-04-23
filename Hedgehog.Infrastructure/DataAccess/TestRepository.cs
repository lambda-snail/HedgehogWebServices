using Hedgehog.Core.Contracts;
using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain;

namespace Hedgehog.Infrastructure.DataAccess
{
    class TestRepository : ITestRepository
    {
        public ITestService GetTestService(string msg = null)
        {
            return new TestService(msg);
        }
    }
}
