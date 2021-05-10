using Hedgehog.Core.Application;
using System.Threading.Tasks;

namespace Hedgehog.Core.Contracts.InfrastructureContracts
{
    /// <summary>
    /// The built-in UserManager does not load navigation properties. This class provides a method
    /// to load users including navigation properties, when they are needed. If not needed, the normal
    /// way to get user information via UserManager is preferred.
    /// 
    /// It is intended to be injected into request handlers that need it.
    /// </summary>
    public interface ICustomerAccountManagerExtensions
    {
        Task<CustomerAccount> GetByIdAsyncWithNavigation(string userId);
    }
}