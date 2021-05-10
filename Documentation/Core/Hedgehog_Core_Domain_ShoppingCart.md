#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain](Hedgehog_Core_Domain.md 'Hedgehog.Core.Domain')
## ShoppingCart Class
A simple shopping cart that is designed to be small and thus should be relatively cheap to instantiate  
as needed during the handling of a request.  
```csharp
public class ShoppingCart :
Hedgehog.Core.Contracts.DomainContracts.IShoppingCart
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ShoppingCart  

Implements [Hedgehog.Core.Contracts.DomainContracts.IShoppingCart](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.DomainContracts.IShoppingCart 'Hedgehog.Core.Contracts.DomainContracts.IShoppingCart')  
### Properties

***
[StoreId](Hedgehog_Core_Domain_ShoppingCart_StoreId.md 'Hedgehog.Core.Domain.ShoppingCart.StoreId')

The Id of the store is saved to prevent shopping carts accidentally being transferred between  
sessions of different customers.  
### Methods

***
[AddToCart(int, int)](Hedgehog_Core_Domain_ShoppingCart_AddToCart(int_int).md 'Hedgehog.Core.Domain.ShoppingCart.AddToCart(int, int)')

Add an amount of the given product. If a product with the given id does not exist in the cart, it will be  
added with the specified amount.  

***
[CalculateTotal()](Hedgehog_Core_Domain_ShoppingCart_CalculateTotal().md 'Hedgehog.Core.Domain.ShoppingCart.CalculateTotal()')

Calculates the total cost of all items in the shopping cart. This call will connect  
to the database.  

***
[RemoveFromCart(int, int)](Hedgehog_Core_Domain_ShoppingCart_RemoveFromCart(int_int).md 'Hedgehog.Core.Domain.ShoppingCart.RemoveFromCart(int, int)')

Removes a given quantity of the specified product from the shopping cart. If a product with the given id   
does not exist in the cart, the method will exit silently.  
