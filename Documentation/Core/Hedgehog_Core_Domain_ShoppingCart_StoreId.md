#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain](Hedgehog_Core_Domain.md 'Hedgehog.Core.Domain').[ShoppingCart](Hedgehog_Core_Domain_ShoppingCart.md 'Hedgehog.Core.Domain.ShoppingCart')
## ShoppingCart.StoreId Property
The Id of the store is saved to prevent shopping carts accidentally being transferred between  
sessions of different customers.  
```csharp
public int StoreId { get; set; }
```
#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Implements [StoreId](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.DomainContracts.IShoppingCart.StoreId 'Hedgehog.Core.Contracts.DomainContracts.IShoppingCart.StoreId')  
