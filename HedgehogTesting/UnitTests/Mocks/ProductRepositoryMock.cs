using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain;
using Hedgehog.Infrastructure.DataAccess;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace HedgehogTesting.UnitTests.Mocks
{
    class ProductRepositoryMock
    {
        /// <summary>
        /// Sets up a simple mock repository with products from two stores.
        /// </summary>
        /// <returns></returns>
        public static Mock<IProductRepository> GetMockProductRepository()
        {
            List<Product> products = new()
            {
                new Product()
                {
                    ProductId = 1,
                    ProductName = "test1",
                    ShortDescription = "abc",
                    LongDescription = "abcdefg",
                    Price = 1.0,
                    ImageUrl = "https://img.com",
                    WebStore = null,
                    WebStoreId = 1
                },
                new Product()
                {
                    ProductId = 2,
                    ProductName = "test2",
                    ShortDescription = "abc",
                    LongDescription = "abcdefg",
                    Price = 1.0,
                    ImageUrl = "https://img.com",
                    WebStore = null,
                    WebStoreId = 1
                },
                new Product()
                {
                    ProductId = 3,
                    ProductName = "test3",
                    ShortDescription = "abc",
                    LongDescription = "abcdefg",
                    Price = 1.0,
                    ImageUrl = "https://img.com",
                    WebStore = null,
                    WebStoreId = 1
                },
                new Product()
                {
                    ProductId = 4,
                    ProductName = "test4",
                    ShortDescription = "abc",
                    LongDescription = "abcdefg",
                    Price = 1.0,
                    ImageUrl = "https://img.com",
                    WebStore = null,
                    WebStoreId = 2
                }
            };

            Mock<IProductRepository> repo = new();
            
            repo.Setup(r => r.GetProductsFromWebStoreIdAsync(It.IsAny<int>()))
                .ReturnsAsync(
                    (int id) => products.Where(p => p.WebStoreId==id).Select(p=>p).ToList()
                );

            repo.Setup(r => r.GetProductsFromWebStorePagedAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()))
                .ReturnsAsync(
                    (int storeId, int page, int pageSize) => 
                        products.Where(product => product.WebStoreId == storeId)
                                .Skip((page - 1) * pageSize).Take(pageSize));

            repo.Setup(r => r.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((int id) => products.FirstOrDefault(p => p.ProductId == id));


            return repo;
        }
    }
}
