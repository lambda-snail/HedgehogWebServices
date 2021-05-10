#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories').[IWebStoreRepository](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IWebStoreRepository.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IWebStoreRepository')
## IWebStoreRepository.GetWebStoreFromUser(string) Method
Returns the WebStore owned by the specified user.  
```csharp
System.Threading.Tasks.Task<Hedgehog.Core.Domain.WebStore> GetWebStoreFromUser(string guid);
```
#### Parameters
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IWebStoreRepository_GetWebStoreFromUser(string)_guid'></a>
`guid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The id of the user who owns the store.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[WebStore](Hedgehog_Core_Domain_WebStore.md 'Hedgehog.Core.Domain.WebStore')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
