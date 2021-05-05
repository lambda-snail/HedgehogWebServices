using Hedgehog.Core.Application;
using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain;
using HedgehogTesting.UnitTests.TestData;
using Microsoft.AspNetCore.Identity;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace HedgehogTesting.UnitTests.Mocks
{
    class OrderRepositoryMock
    {
        public static Mock<IOrderRepository> GetMockProductRepository()
        {
            Address address = AddressTestData.Get();
            WebStore store = WebStoreTestData.Get();
            CustomerAccount customer = CustomerTestData.Get("00000000-0000-0000-0000-000000000000", store );
            CustomerAccount customer2 = CustomerTestData.Get("22222222-2222-2222-2222-222222222222", store);

            List<OrderItem> orderItems = new List<OrderItem>()
            {
                new OrderItem { OrderItemId=1, Amount=10, ProductName="Test 1", ProductPrice=10d, ProductShortDescription="Foobar" },
                new OrderItem { OrderItemId=2, Amount=5, ProductName="Test 2", ProductPrice=5d, ProductShortDescription="Foobar" },
                new OrderItem { OrderItemId=3, Amount=1, ProductName="Test 3", ProductPrice=22.45d, ProductShortDescription="Foobar" }
            };

            List<OrderItem> orderItems2 = new List<OrderItem>()
            {
                new OrderItem { OrderItemId=5, Amount=1000, ProductName="Test 5", ProductPrice=10d, ProductShortDescription="Foobar" },
                new OrderItem { OrderItemId=6, Amount=50, ProductName="Test 6", ProductPrice=50d, ProductShortDescription="Foobar" }
            };

            List<OrderItem> orderItems3 = new List<OrderItem>()
            {
                new OrderItem { OrderItemId=7, Amount=200, ProductName="Test 7", ProductPrice=1d, ProductShortDescription="Foobar" }
            };

            List<Order> orders = new List<Order>()
            {
                new Order { OrderId=1, CreatedTime= System.DateTime.Now, Customer=customer, FinalizedTime=null, ShippingAddress=address, OrderItems=orderItems },
                new Order { OrderId = 2, CreatedTime = System.DateTime.Now, Customer = customer, FinalizedTime = null, ShippingAddress = address, OrderItems = orderItems },
                new Order { OrderId = 3, CreatedTime = System.DateTime.Now, Customer = customer2, FinalizedTime = null, ShippingAddress = address, OrderItems = orderItems }
            };


            Mock<IOrderRepository> repo = new();

            repo.Setup(r => r.GetOrderByCustomerIdAsync(It.IsAny<string>()))
                .ReturnsAsync(
                    (string userId) => orders.Where(o => o.Customer.Id == userId)
                );

            return null;
        }
    }
}