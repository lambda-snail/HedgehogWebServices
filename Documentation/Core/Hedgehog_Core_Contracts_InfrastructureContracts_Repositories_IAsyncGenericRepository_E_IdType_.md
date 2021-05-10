#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories')
## IAsyncGenericRepository&lt;E,IdType&gt; Interface
Defines generic async CRUD operations.  
```csharp
public interface IAsyncGenericRepository<E,IdType>
    where E : class
    where IdType : struct
```
#### Type parameters
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType__E'></a>
`E`  
A type that exists in the DbContext of the application.
  
<a name='Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType__IdType'></a>
`IdType`  
The type of the primary key for T.
  

Derived  
&#8627; [IOrderRepository](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IOrderRepository.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IOrderRepository')  
&#8627; [IProductRepository](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IProductRepository.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IProductRepository')  
&#8627; [IWebStoreRepository](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IWebStoreRepository.md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IWebStoreRepository')  
### Methods

***
[GetPagedAsync(int, int, Func&lt;E,bool&gt;)](Hedgehog_Core_Contracts_InfrastructureContracts_Repositories_IAsyncGenericRepository_E_IdType__GetPagedAsync(int_int_System_Func_E_bool_).md 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;E,IdType&gt;.GetPagedAsync(int, int, System.Func&lt;E,bool&gt;)')

Retreives paged results from the database, with an optional filter specfied.  
