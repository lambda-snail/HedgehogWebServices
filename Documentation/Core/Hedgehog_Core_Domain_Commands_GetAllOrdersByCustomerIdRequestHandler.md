#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain.Commands](Hedgehog_Core_Domain_Commands.md 'Hedgehog.Core.Domain.Commands')
## GetAllOrdersByCustomerIdRequestHandler Class
Retreives all orders in the DB for a given customer.  
```csharp
public class GetAllOrdersByCustomerIdRequestHandler :
MediatR.IRequestHandler<Hedgehog.Core.Domain.Requests.GetAllOrdersByCustomerIdRequest, System.Collections.Generic.IEnumerable<Hedgehog.Core.Domain.Order>>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GetAllOrdersByCustomerIdRequestHandler  

Implements [MediatR.IRequestHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')[Hedgehog.Core.Domain.Requests.GetAllOrdersByCustomerIdRequest](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Domain.Requests.GetAllOrdersByCustomerIdRequest 'Hedgehog.Core.Domain.Requests.GetAllOrdersByCustomerIdRequest')[,](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Order](Hedgehog_Core_Domain_Order.md 'Hedgehog.Core.Domain.Order')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')  
