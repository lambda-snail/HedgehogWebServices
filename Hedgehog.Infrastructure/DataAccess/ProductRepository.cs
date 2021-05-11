
using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hedgehog.Infrastructure.DataAccess
{
    public class ProductRepository : RepositoryBase<Product, int>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetProductsFromWebStoreIdAsync(int storeId)
        {
            return await _database.Set<Product>().Include(product => product.WebStore)
                                  .Where(product => product.WebStoreId == storeId)
                                  .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsFromWebStorePagedAsync(int storeId, int page, int pageSize)
        {
            return await _database.Set<Product>().Include(product => product.WebStore)
                                  .Where(product => product.WebStoreId == storeId)
                                  .Skip((page-1)*pageSize).Take(pageSize)
                                  .AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Product>> SearchProductsFromWebStoreAsync(int storeId, string searchString)
        {
            return await _database.Set<Product>().Include(product => product.WebStore)
                                  .Where(
                                    product => product.WebStoreId == storeId 
                                    && (product.ProductName.Contains(searchString) 
                                        || product.ShortDescription.Contains(searchString) 
                                        || product.LongDescription.Contains(searchString)
                                       )
                                  ).AsNoTracking().ToListAsync();
        }
    }
}
