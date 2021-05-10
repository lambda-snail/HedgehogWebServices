#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories')
## IProductRepository Interface
An interface that allows more specific operations on the Product database, compared to the generic repository.  
```csharp
public interface IProductRepository :
Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository<Hedgehog.Core.Domain.Product, int>
```

Implements [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')[Product](Hedgehog_Core_Domain_Product.md 'Hedgehog.Core.Domain.Product')[,](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')  
### Methods

***
[GetProductsFromWebStoreIdAsync(int)](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IProductRepository_GetProductsFromWebStoreIdAsync(int).md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IProductRepository.GetProductsFromWebStoreIdAsync(int)')

Returns a collection of all products associated with a given store.  

***
[GetProductsFromWebStorePagedAsync(int, int, int)](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IProductRepository_GetProductsFromWebStorePagedAsync(int_int_int).md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IProductRepository.GetProductsFromWebStorePagedAsync(int, int, int)')

Returns a paged collection of products associated with a given store.  
