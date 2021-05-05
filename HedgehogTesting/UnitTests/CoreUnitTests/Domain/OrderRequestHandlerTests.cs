using Hedgehog.Core.Application;
using Hedgehog.Core.Domain;
using Hedgehog.Core.Domain.Commands;
using Hedgehog.Core.Domain.Requests;
using HedgehogTesting.UnitTests.TestData;
using MediatR;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Xunit;

namespace HedgehogTesting.UnitTests.CoreUnitTests.Domain
{
    public class OrderRequestHandlerTests
    {
        [Fact]
        public async void CreateOrderRequestHandlerTest_ValidData_NoSaveToDb()
        {
            Address address = AddressTestData.Get();
            WebStore store = WebStoreTestData.Get();
            CustomerAccount customer = CustomerTestData.Get("00000000-0000-0000-0000-000000000000", store);
            ShoppingCart cart = ShoppingCartTestData.Get(store.WebStoreId, new List<int> { 1, 2, 3, 4, 5 });

            var request = new CreateOrderRequest { Address=address, Cart=cart, Customer=customer, SaveToDatabase=false };

            // Since the handler uses another call to mediator to get a product from the database, we need to
            // mock that behavior here
            var mediator = new Mock<IMediator>();
            mediator.Setup(m => m.Send(It.IsAny<GetSingleProductFromStoreRequest>(), It.IsAny<CancellationToken>()))
                    .ReturnsAsync((GetSingleProductFromStoreRequest request, CancellationToken token) =>
                        new Product { ProductId = request.ProductId, ProductName = "test", ShortDescription = "foobar", Price = 10.0d, WebStoreId = store.WebStoreId, WebStore = store }
                    );

            var handler = new CreateOrderRequestHandler( mediator.Object );

            Order result = await handler.Handle(request, CancellationToken.None);

            Assert.NotNull(result);
            Assert.Equal(cart.Items.Count(), result.OrderItems.Count());
        }
    }
}
