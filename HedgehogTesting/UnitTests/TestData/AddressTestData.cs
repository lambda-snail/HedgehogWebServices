using Hedgehog.Core.Domain;

namespace HedgehogTesting.UnitTests.TestData
{
    class AddressTestData
    {
        public static Address Get()
        {
            return new Address { AddressId = 1, City = "Stockholm", Country = "Sweden", Receiver = "Smith", StreetAddress = "Storgatan", ZipCode = "11111" };
        }
    }
}
