#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain.Commands](Hedgehog_Core_Domain_Commands.md 'Hedgehog.Core.Domain.Commands')
## CreateOrderRequestHandler Class
This command handler takes care of everything that is needed to create an order based on a shopping cart  
and is the prefferred way to do so.  
  
Any order items with an amount of 0 will be ignored.  
```csharp
public class CreateOrderRequestHandler :
MediatR.IRequestHandler<Hedgehog.Core.Domain.Requests.CreateOrderRequest, Hedgehog.Core.Domain.Order>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CreateOrderRequestHandler  

Implements [MediatR.IRequestHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')[CreateOrderRequest](Hedgehog_Core_Domain_Requests_CreateOrderRequest.md 'Hedgehog.Core.Domain.Requests.CreateOrderRequest')[,](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')[Order](Hedgehog_Core_Domain_Order.md 'Hedgehog.Core.Domain.Order')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequestHandler-2 'MediatR.IRequestHandler`2')  
