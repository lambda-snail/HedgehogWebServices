#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories')
## IOrderRepository Interface
An interface that allows more specific operations on the Order database, compared to the generic repository.  
```csharp
public interface IOrderRepository :
Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository<Hedgehog.Core.Domain.Order, int>
```

Implements [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')[Order](Hedgehog_Core_Domain_Order.md 'Hedgehog.Core.Domain.Order')[,](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')  
### Methods

***
[GetOrdersByCustomerIdAsync(string)](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IOrderRepository_GetOrdersByCustomerIdAsync(string).md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IOrderRepository.GetOrdersByCustomerIdAsync(string)')

Retreive all orders related to a given user.  
