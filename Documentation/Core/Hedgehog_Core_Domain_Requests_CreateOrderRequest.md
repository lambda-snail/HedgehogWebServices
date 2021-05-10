#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain.Requests](Hedgehog_Core_Domain_Requests.md 'Hedgehog.Core.Domain.Requests')
## CreateOrderRequest Class
```csharp
public class CreateOrderRequest :
MediatR.IRequest<Hedgehog.Core.Domain.Order>,
MediatR.IBaseRequest
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; CreateOrderRequest  

Implements [MediatR.IRequest&lt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequest-1 'MediatR.IRequest`1')[Order](Hedgehog_Core_Domain_Order.md 'Hedgehog.Core.Domain.Order')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequest-1 'MediatR.IRequest`1'), [MediatR.IBaseRequest](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IBaseRequest 'MediatR.IBaseRequest')  
### Properties

***
[SaveToDatabase](Hedgehog_Core_Domain_Requests_CreateOrderRequest_SaveToDatabase.md 'Hedgehog.Core.Domain.Requests.CreateOrderRequest.SaveToDatabase')

Should the resulting order be saved to the database when created?  
Defaults to false.  
