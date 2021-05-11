using Hedgehog.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hedgehog.Core.Contracts.InfrastructureContracts.Repositories
{
    /// <summary>
    /// An interface that allows more specific operations on the Product database, compared to the generic repository.
    /// </summary>
    public interface IProductRepository : IAsyncGenericRepository<Product, int>
    {
        /// <summary>
        /// Returns a collection of all products associated with a given store.
        /// </summary>
        Task<IEnumerable<Product>> GetProductsFromWebStoreIdAsync(int storeId);
        
        /// <summary>
        /// Returns a paged collection of products associated with a given store.
        /// </summary>
        Task<IEnumerable<Product>> GetProductsFromWebStorePagedAsync(int storeId, int page, int pageSize);

        /// <summary>
        /// Returns a subset of all products in a given web store.
        /// </summary>
        /// <param name="searchString">The search string will be matched against the product title, short and long descriptions.</param>
        Task<IEnumerable<Product>> SearchProductsFromWebStoreAsync(int storeId, string searchString);
    }
}
