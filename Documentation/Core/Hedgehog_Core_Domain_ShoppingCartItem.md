#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain](Hedgehog_Core_Domain.md 'Hedgehog.Core.Domain')
## ShoppingCartItem Class
An item in a shopping cart consisting of a product id and an amount. The class is designed to  
be lightweight to allow for efficient serialization and deserialization, as well as storage in  
the browser session.  
  
As only product id is stored, the product object must be retreived from the database before processing.  
```csharp
public class ShoppingCartItem
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ShoppingCartItem  
