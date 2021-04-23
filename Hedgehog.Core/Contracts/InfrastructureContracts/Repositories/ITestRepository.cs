using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hedgehog.Core.Contracts.InfrastructureContracts.Repositories
{
    public interface ITestRepository
    {
        public ITestService GetTestService(string msg);
    }
}
