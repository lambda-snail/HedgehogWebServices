using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hedgehog.Infrastructure.DataAccess
{
    public class RepositoryBase<E, IdType> : IAsyncGenericRepository<E, IdType> where E : class where IdType : struct
    {
        protected readonly ApplicationDbContext _database;

        public RepositoryBase(ApplicationDbContext database)
        {
            _database = database;
        }

        public virtual async Task AddAsync(E entity)
        {
            await _database.Set<E>().AddAsync(entity);
            await _database.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(E entity)
        {
            _database.Set<E>().Remove(entity);
            await _database.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<E>> GetAllAsync()
        {
            return await _database.Set<E>().ToListAsync();
        }

        public virtual async Task<E> GetByIdAsynch(IdType id)
        {
            return await _database.Set<E>().FindAsync(id);
        }

        public virtual async Task<IEnumerable<E>> GetPagedAsync(int page, int pageSize, Func<E, bool> predicate = null)
        {
            // If predicate is null we use a function that selects everything
            Func<E, bool> f = predicate ?? ((E x)=>true);
            return await _database.Set<E>().Where(e => f(e)).Skip((page - 1) * pageSize).Take(pageSize).AsNoTracking().ToListAsync();
        }

        public virtual async Task UpdateAsync(E entity)
        {
            _database.Set<E>().Update(entity);
            await _database.SaveChangesAsync();
        }
    }
}
