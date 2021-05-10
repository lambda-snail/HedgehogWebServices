#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories').[IAsyncGenericRepository&lt;E,IdType&gt;](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;')
## IAsyncGenericRepository&lt;E,IdType&gt;.GetPagedAsync(int, int, Func&lt;E,bool&gt;) Method
Retreives paged results from the database, with an optional filter specfied.  
```csharp
System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<E>> GetPagedAsync(int page, int pageSize, System.Func<E,bool> predicate=null);
```
#### Parameters
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType__GetPagedAsync(int_int_System_Func_E_bool_)_page'></a>
`page` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Pages are indexed starting with 1 as the first page.
  
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType__GetPagedAsync(int_int_System_Func_E_bool_)_pageSize'></a>
`pageSize` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType__GetPagedAsync(int_int_System_Func_E_bool_)_predicate'></a>
`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[E](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md#Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType__E 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;.E')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
An optional filter applied before querying the database.
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[E](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType_.md#Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType__E 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;.E')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
