#### [Hedgehog.Infrastructure](index.md 'index')
### [Hedgehog.Infrastructure.DataAccess](Hedgehog_Infrastructure_DataAccess.md 'Hedgehog.Infrastructure.DataAccess').[OrderRepository](Hedgehog_Infrastructure_DataAccess_OrderRepository.md 'Hedgehog.Infrastructure.DataAccess.OrderRepository')
## OrderRepository.GetByIdAsync(int) Method
Override base class method to allow inclusion of all navigation properties.  
```csharp
public override System.Threading.Tasks.Task<Hedgehog.Core.Domain.Order> GetByIdAsync(int id);
```
#### Parameters
<a name='Hedgehog_Infrastructure_DataAccess_OrderRepository_GetByIdAsync(int)_id'></a>
`id` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[Hedgehog.Core.Domain.Order](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Domain.Order 'Hedgehog.Core.Domain.Order')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
