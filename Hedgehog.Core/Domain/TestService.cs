using Hedgehog.Core.Contracts;

namespace Hedgehog.Core.Domain
{
    public class TestService : ITestService
    {
        public string GetMessage()
        {
            return "Hello Dependency Injection World!";
        }
    }
}
