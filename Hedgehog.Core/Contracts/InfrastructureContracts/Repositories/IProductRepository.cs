using Hedgehog.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hedgehog.Core.Contracts.InfrastructureContracts.Repositories
{
    public interface IProductRepository
    {
        /// <summary>
        /// Returns a collection of all products associated with a given store.
        /// </summary>
        Task<IEnumerable<Product>> GetProductsFromWebStoreIdAsync(int storeId);
        /// <summary>
        /// Returns a paged collection of products associated with a given store.
        /// </summary>
        Task<IEnumerable<Product>> GetProductsFromWebStorePagedAsync(int storeId, int page, int pageSize);
    }
}
