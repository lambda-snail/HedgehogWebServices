using Hedgehog.Core.Domain;
using System.Threading.Tasks;

namespace Hedgehog.Core.Contracts.InfrastructureContracts.Repositories
{
    /// <summary>
    /// An interface with special methods for interacting with the WebStore classes in the database.
    /// </summary>
    public interface IWebStoreRepository : IAsyncGenericRepository<WebStore, int>
    {
        /// <summary>
        /// Returns the WebStore owned by the specified user.
        /// </summary>
        /// <param name="guid">The id of the user who owns the store.</param>
        Task<WebStore> GetWebStoreFromUser(string guid);

        /// <summary>
        /// Finds the WebStore that is associated with the specified navigation name (i.e. the part of the url that is used to identify the web store in the UI).
        /// </summary>
        Task<WebStore> GetWebStoreFromNavigationTitle(string navigationName);
    }
}
