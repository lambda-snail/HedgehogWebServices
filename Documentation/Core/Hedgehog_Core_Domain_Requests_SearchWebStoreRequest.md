#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain.Requests](Hedgehog_Core_Domain_Requests.md 'Hedgehog.Core.Domain.Requests')
## SearchWebStoreRequest Class
Search a given web store for products with the given string in their description or title.  
```csharp
public class SearchWebStoreRequest :
MediatR.IRequest<System.Collections.Generic.IEnumerable<Hedgehog.Core.Domain.Product>>,
MediatR.IBaseRequest
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SearchWebStoreRequest  

Implements [MediatR.IRequest&lt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequest-1 'MediatR.IRequest`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[Product](Hedgehog_Core_Domain_Product.md 'Hedgehog.Core.Domain.Product')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IRequest-1 'MediatR.IRequest`1'), [MediatR.IBaseRequest](https://docs.microsoft.com/en-us/dotnet/api/MediatR.IBaseRequest 'MediatR.IBaseRequest')  
