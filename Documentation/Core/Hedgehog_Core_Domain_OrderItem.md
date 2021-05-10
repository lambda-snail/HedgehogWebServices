#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain](Hedgehog_Core_Domain.md 'Hedgehog.Core.Domain')
## OrderItem Class
Represents a product that is part of an order. There is no reference to a Product object  
here, instead the OrderItem will store some properties of the Product from which it derives.  
This is so that changes in a Product in the Db will not have strange effects on already completed  
orders.  
```csharp
public class OrderItem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; OrderItem  
