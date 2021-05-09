using Hedgehog.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hedgehog.Core.Contracts.InfrastructureContracts.Repositories
{
    public interface IOrderRepository : IAsyncGenericRepository<Order, int>
    {
        /// <summary>
        /// Retreive all orders related to a given user.
        /// </summary>
        public Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(string customerId);
    }
}
