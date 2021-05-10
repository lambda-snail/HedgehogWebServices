#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories').[IOrderRepository](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IOrderRepository.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IOrderRepository')
## IOrderRepository.GetOrdersByCustomerIdAsync(string) Method
Retreive all orders related to a given user.  
```csharp
System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Hedgehog.Core.Domain.Order>> GetOrdersByCustomerIdAsync(string customerId);
```
#### Parameters
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IOrderRepository_GetOrdersByCustomerIdAsync(string)_customerId'></a>
`customerId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Order](Hedgehog_Core_Domain_Order.md 'Hedgehog.Core.Domain.Order')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
