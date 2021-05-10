using Hedgehog.Core.Application;
using Hedgehog.Core.Domain;

namespace HedgehogTesting.UnitTests.TestData
{
    class CustomerTestData
    {
        public static CustomerAccount Get(string id, WebStore store = null)
        {
            return new CustomerAccount { WebStore = store, Id = id };
        }
    }
}
