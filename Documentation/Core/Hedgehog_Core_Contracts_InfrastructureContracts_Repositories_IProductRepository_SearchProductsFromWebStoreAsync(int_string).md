#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories').[IProductRepository](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IProductRepository.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IProductRepository')
## IProductRepository.SearchProductsFromWebStoreAsync(int, string) Method
Returns a subset of all products in a given web store.  
```csharp
System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Hedgehog.Core.Domain.Product>> SearchProductsFromWebStoreAsync(int storeId, string searchString);
```
#### Parameters
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IProductRepository_SearchProductsFromWebStoreAsync(int_string)_storeId'></a>
`storeId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IProductRepository_SearchProductsFromWebStoreAsync(int_string)_searchString'></a>
`searchString` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The search string will be matched against the product title, short and long descriptions.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Product](Hedgehog_Core_Domain_Product.md 'Hedgehog.Core.Domain.Product')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
