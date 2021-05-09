using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hedgehog.Infrastructure.DataAccess
{
    public class OrderRepository : RepositoryBase<Order, int>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext database) : base(database) {}

        public async Task<IEnumerable<Order>> GetOrdersByCustomerIdAsync(string customerId)
        {
            return await _database.Set<Order>().Where(order => order.Customer.Id == customerId)
                                  .Include(order => order.Customer)
                                  .Include(order => order.ShippingAddress)
                                  .Include(order => order.OrderItems)
                                  .ToListAsync();
        }

        /// <summary>
        /// Override base class method to allow inclusion of all navigation properties.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public override async Task<Order> GetByIdAsync(int id)
        {
            return await _database.Set<Order>()
                                  .Include(order => order.Customer)
                                  .Include(order => order.ShippingAddress)
                                  .Include(order => order.OrderItems)
                                  .FirstOrDefaultAsync(order => order.OrderId == id);
        }
    }
}
