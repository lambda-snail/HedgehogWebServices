#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories')
## IWebStoreRepository Interface
An interface that allows more specific operations on the WebStore database, compared to the generic repository.  
```csharp
public interface IWebStoreRepository :
Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository<Hedgehog.Core.Domain.WebStore, int>
```

Implements [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')[WebStore](Hedgehog_Core_Domain_WebStore.md 'Hedgehog.Core.Domain.WebStore')[,](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')  
### Methods

***
[GetWebStoreFromNavigationTitle(string)](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IWebStoreRepository_GetWebStoreFromNavigationTitle(string).md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IWebStoreRepository.GetWebStoreFromNavigationTitle(string)')

Finds the WebStore that is associated with the specified navigation name (i.e. the part of the url that is used to identify the web store in the UI).  

***
[GetWebStoreFromUser(string)](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IWebStoreRepository_GetWebStoreFromUser(string).md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IWebStoreRepository.GetWebStoreFromUser(string)')

Returns the WebStore owned by the specified user.  
