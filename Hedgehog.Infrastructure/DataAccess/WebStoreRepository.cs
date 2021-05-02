using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hedgehog.Infrastructure.DataAccess
{
    public class WebStoreRepository : RepositoryBase<WebStore, int>, IWebStoreRepository
    {
        public WebStoreRepository(ApplicationDbContext database) : base(database)
        {
        }

        public async Task<WebStore> GetWebStoreFromUser(string guid)
        {
            return await _database.Set<WebStore>().Include(store => store.Owner).FirstOrDefaultAsync(store => store.Owner.Id == guid);
        }

        public async Task<WebStore> GetWebStoreFromNavigationTitle(string navigationTitle)
        {
            return await _database.Set<WebStore>().FirstOrDefaultAsync(store => store.NavigationTitle == navigationTitle);
        }
    }
}
