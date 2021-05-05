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

        public async Task<IEnumerable<Order>> GetOrderByCustomerIdAsync(string userId)
        {
            return await _database.Set<Order>().Include(order => order.Customer)
                                  .Include(order => order.ShippingAddress)
                                  .Include(order => order.OrderItems)
                                  .Where(order => order.Customer.Id == userId)
                                  .ToListAsync();
        }
    }
}
