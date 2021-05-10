#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain](Hedgehog_Core_Domain.md 'Hedgehog.Core.Domain').[ShoppingCart](Hedgehog_Core_Domain_ShoppingCart.md 'Hedgehog.Core.Domain.ShoppingCart')
## ShoppingCart.RemoveFromCart(int, int) Method
Removes a given quantity of the specified product from the shopping cart. If a product with the given id   
does not exist in the cart, the method will exit silently.  
```csharp
public void RemoveFromCart(int ProductId, int amount=1);
```
#### Parameters
<a name='Hedgehog_Core_Domain_ShoppingCart_RemoveFromCart(int_int)_ProductId'></a>
`ProductId` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
  
<a name='Hedgehog_Core_Domain_ShoppingCart_RemoveFromCart(int_int)_amount'></a>
`amount` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
Defaults to 1.
  
#### Exceptions
[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
If amount is less than or equal to 0.

Implements [RemoveFromCart(int, int)](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.DomainContracts.IShoppingCart.RemoveFromCart#Hedgehog_Core_Contracts_DomainContracts_IShoppingCart_RemoveFromCart_System_Int32,System_Int32_ 'Hedgehog.Core.Contracts.DomainContracts.IShoppingCart.RemoveFromCart(System.Int32,System.Int32)')  
