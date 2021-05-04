using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain;
using Hedgehog.Core.Domain.Commands;
using Hedgehog.Core.Domain.Requests;
using Hedgehog.Infrastructure.DataAccess;
using HedgehogTesting.UnitTests.Mocks;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace HedgehogTesting.UnitTests.CoreUnitTests.Domain
{
    public class ProductRequestHandlerTests
    {
        Mock<IProductRepository> _productRepository;

        public ProductRequestHandlerTests()
        {
            _productRepository = ProductRepositoryMock.GetMockProductRepository();
        }

        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(1, 3, 3)]
        [InlineData(2, 4, 4)]
        public async Task GetSingleProductFromStoreRequestHandler_ExistingProduct(int StoreId, int ProductId, int expectedId)
        {
            GetSingleProductFromStoreRequest request = new() { StoreId= StoreId, ProductId= ProductId };
            GetSingleProductFromStoreRequestHandler handler = new(_productRepository.Object);

            Product result = await handler.Handle(request, CancellationToken.None);

            Assert.Equal(expectedId, result.ProductId);
        }

        [Theory]
        [InlineData(1,5)]
        [InlineData(2, 10)]
        public async Task GetSingleProductFromStoreRequestHandler_NonexistingProduct(int StoreId, int ProductId)
        {
            GetSingleProductFromStoreRequest request = new() { StoreId = StoreId, ProductId = ProductId };
            GetSingleProductFromStoreRequestHandler handler = new(_productRepository.Object);

            Product result = await handler.Handle(request, CancellationToken.None);

            Assert.Null(result);
        }

        [Theory]
        [InlineData(1,3)]
        [InlineData(2, 1)]
        public async Task GetProductsFromStoreRequestHandler_ExistingProduct(int storeId, int expectedCount)
        {
            GetProductsFromStoreRequest request = new() { StoreId = storeId };
            GetProductsFromStoreReqestHandler handler = new(_productRepository.Object);

            IEnumerable<Product> result = await handler.Handle(request, CancellationToken.None);

            Assert.Equal(expectedCount, result.Count());
        }

        [Theory]
        [InlineData(10)]
        [InlineData(0)]
        public async Task GetProductsFromStoreRequestHandler_NonexistingProduct(int storeId)
        {
            GetProductsFromStoreRequest request = new() { StoreId = storeId };
            GetProductsFromStoreReqestHandler handler = new(_productRepository.Object);

            IEnumerable<Product> result = await handler.Handle(request, CancellationToken.None);

            Assert.Empty(result);
            Assert.NotNull(result);
        }
    }
}
