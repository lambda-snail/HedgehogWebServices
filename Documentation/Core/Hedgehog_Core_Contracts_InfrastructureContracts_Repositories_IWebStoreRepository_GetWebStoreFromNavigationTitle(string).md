#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories').[IWebStoreRepository](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IWebStoreRepository.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IWebStoreRepository')
## IWebStoreRepository.GetWebStoreFromNavigationTitle(string) Method
Finds the WebStore that is associated with the specified navigation name (i.e. the part of the url that is used to identify the web store in the UI).  
```csharp
System.Threading.Tasks.Task<Hedgehog.Core.Domain.WebStore> GetWebStoreFromNavigationTitle(string navigationName);
```
#### Parameters
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IWebStoreRepository_GetWebStoreFromNavigationTitle(string)_navigationName'></a>
`navigationName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[WebStore](Hedgehog_Core_Domain_WebStore.md 'Hedgehog.Core.Domain.WebStore')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
