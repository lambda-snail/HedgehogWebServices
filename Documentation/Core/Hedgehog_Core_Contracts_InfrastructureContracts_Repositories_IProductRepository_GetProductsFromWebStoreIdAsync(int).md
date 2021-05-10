#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories').[IProductRepository](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IProductRepository.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IProductRepository')
## IProductRepository.GetProductsFromWebStoreIdAsync(int) Method
Returns a collection of all products associated with a given store.  
```csharp
System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Hedgehog.Core.Domain.Product>> GetProductsFromWebStoreIdAsync(int storeId);
```
#### Parameters
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IProductRepository_GetProductsFromWebStoreIdAsync(int)_storeId'></a>
`storeId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Product](Hedgehog_Core_Domain_Product.md 'Hedgehog.Core.Domain.Product')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
