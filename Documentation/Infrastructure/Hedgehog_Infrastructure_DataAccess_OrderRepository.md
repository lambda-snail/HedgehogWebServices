#### [Hedgehog.Infrastructure](index.md 'index')
### [Hedgehog.Infrastructure.DataAccess](Hedgehog_Infrastructure_DataAccess.md 'Hedgehog.Infrastructure.DataAccess')
## OrderRepository Class
```csharp
public class OrderRepository : Hedgehog.Infrastructure.DataAccess.RepositoryBase<Hedgehog.Core.Domain.Order, int>,
Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IOrderRepository,
Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository<Hedgehog.Core.Domain.Order, int>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Hedgehog.Infrastructure.DataAccess.RepositoryBase&lt;](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Infrastructure.DataAccess.RepositoryBase-2 'Hedgehog.Infrastructure.DataAccess.RepositoryBase`2')[Hedgehog.Core.Domain.Order](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Domain.Order 'Hedgehog.Core.Domain.Order')[,](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Infrastructure.DataAccess.RepositoryBase-2 'Hedgehog.Infrastructure.DataAccess.RepositoryBase`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Infrastructure.DataAccess.RepositoryBase-2 'Hedgehog.Infrastructure.DataAccess.RepositoryBase`2') &#129106; OrderRepository  

Implements [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IOrderRepository](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IOrderRepository 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IOrderRepository'), [Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository&lt;](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository-2 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository`2')[Hedgehog.Core.Domain.Order](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Domain.Order 'Hedgehog.Core.Domain.Order')[,](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository-2 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository`2')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository-2 'Hedgehog.Core.Contracts.InfrastructureContracts.Repositories.IAsyncGenericRepository`2')  
### Methods

***
[GetByIdAsync(int)](Hedgehog_Infrastructure_DataAccess_OrderRepository_GetByIdAsync(int).md 'Hedgehog.Infrastructure.DataAccess.OrderRepository.GetByIdAsync(int)')

Override base class method to allow inclusion of all navigation properties.  
