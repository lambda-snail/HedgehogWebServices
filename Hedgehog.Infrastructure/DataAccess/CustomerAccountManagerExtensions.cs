using Hedgehog.Core.Application;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Hedgehog.Infrastructure.DataAccess
{
    public class CustomerAccountManagerExtensions : ICustomerAccountManagerExtensions
    {
        private readonly UserManager<CustomerAccount> _userManager;

        public CustomerAccountManagerExtensions(UserManager<CustomerAccount> userManager)
        {
            _userManager = userManager;
        }

        public async Task<CustomerAccount> GetByIdAsyncWithNavigation(string userId)
        {
            return await _userManager.Users.Include(customer => customer.WebStore).SingleOrDefaultAsync(customer => customer.Id == userId);
        }
    }
}
