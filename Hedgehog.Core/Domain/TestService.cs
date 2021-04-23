using Hedgehog.Core.Contracts;

namespace Hedgehog.Core.Domain
{
    public class TestService : ITestService
    {
        string _msg;
        public TestService(string msg = "Hello Dependency Injection World!")
        {
            _msg = msg;
        }
        public string GetMessage()
        {
            return _msg;
        }
    }
}
