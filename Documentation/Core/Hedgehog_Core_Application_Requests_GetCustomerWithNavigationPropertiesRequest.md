#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Application.Requests](Hedgehog_Core_Application_Requests.md 'Hedgehog.Core.Application.Requests')
## GetCustomerWithNavigationPropertiesRequest Class
The built-in UserManager does not load navigation properties. This class makes a request  
to ensure that these are loaded, and should be used when needed. If not needed, the normal  
way to get user information via UserManager is preferred.  
```csharp
public class GetCustomerWithNavigationPropertiesRequest :
MediatR.IRequest<Hedgehog.Core.Application.CustomerAccount>,
MediatR.IBaseRequest
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; GetCustomerWithNavigationPropertiesRequest  

Implements [MediatR.IRequest&lt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequest-1 'MediatR.IRequest`1')[Hedgehog.Core.Application.CustomerAccount](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Application.CustomerAccount 'Hedgehog.Core.Application.CustomerAccount')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequest-1 'MediatR.IRequest`1'), [MediatR.IBaseRequest](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IBaseRequest 'MediatR.IBaseRequest')  
