using Hedgehog.Core.Domain;

namespace HedgehogTesting.UnitTests.TestData
{
    class WebStoreTestData
    {
        public static WebStore Get()
        {
            return new WebStore { WebStoreId = 1, StoreTitle = "TestStore", NavigationTitle = "teststore", StoreDescription = "foo bar and foobar", UserAccountId = "11111111-1111-1111-1111-111111111111" };
        }
    }
}
