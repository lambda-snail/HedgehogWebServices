using System;
using System.Collections.Generic;
using System.Threading.Tasks;

/// <summary>
/// This namespace contains all interfaces that define how data access works.
/// </summary>
namespace Hedgehog.Core.Contracts.InfrastructureContracts.Repositories
{
    /// <summary>
    /// Defines generic async CRUD operations.
    /// </summary>
    /// <typeparam name="E">A type that exists in the DbContext of the application.</typeparam>
    /// <typeparam name="IdType">The type of the primary key for T.</typeparam>
    public interface IAsyncGenericRepository<E, IdType> where E : class
                                                        where IdType : struct
    {
        // CRUD
        Task AddAsync(E entity);

        Task<E> GetByIdAsync(IdType id);
        Task<IEnumerable<E>> GetAllAsync();
        /// <summary>
        /// Retreives paged results from the database, with an optional filter specfied.
        /// </summary>
        /// <param name="predicate">An optional filter applied before querying the database.</param>
        /// /// <param name="page">Pages are indexed starting with 1 as the first page.</param>
        /// <returns></returns>
        Task<IEnumerable<E>> GetPagedAsync(int page, int pageSize, Func<E, bool> predicate = null);

        Task UpdateAsync(E entity);

        Task DeleteAsync(E entity);
    }
}
