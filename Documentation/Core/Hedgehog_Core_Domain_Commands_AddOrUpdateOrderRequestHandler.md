#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain.Commands](Hedgehog_Core_Domain_Commands.md 'Hedgehog.Core.Domain.Commands')
## AddOrUpdateOrderRequestHandler Class
Adds a new Order to the system or updates an existing. The new or updated order is returned after execution.  
```csharp
public class AddOrUpdateOrderRequestHandler :
MediatR.IRequestHandler<Hedgehog.Core.Domain.Requests.AddOrUpdateOrderRequest>,
MediatR.IRequestHandler<Hedgehog.Core.Domain.Requests.AddOrUpdateOrderRequest, MediatR.Unit>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; AddOrUpdateOrderRequestHandler  

Implements [MediatR.IRequestHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-1 'MediatR.IRequestHandler`1')[AddOrUpdateOrderRequest](Hedgehog_Core_Domain_Requests_AddOrUpdateOrderRequest.md 'Hedgehog.Core.Domain.Requests.AddOrUpdateOrderRequest')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-1 'MediatR.IRequestHandler`1'), [MediatR.IRequestHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')[AddOrUpdateOrderRequest](Hedgehog_Core_Domain_Requests_AddOrUpdateOrderRequest.md 'Hedgehog.Core.Domain.Requests.AddOrUpdateOrderRequest')[,](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')[MediatR.Unit](https://docs.microsoft.com/en-us/dotnet/api/MediatR.Unit 'MediatR.Unit')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')  
