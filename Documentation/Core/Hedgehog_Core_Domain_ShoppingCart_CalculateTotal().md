#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain](Hedgehog_Core_Domain.md 'Hedgehog.Core.Domain').[ShoppingCart](Hedgehog_Core_Domain_ShoppingCart.md 'Hedgehog.Core.Domain.ShoppingCart')
## ShoppingCart.CalculateTotal() Method
Calculates the total cost of all items in the shopping cart. This call will connect  
to the database.  
```csharp
public System.Threading.Tasks.Task<double> CalculateTotal();
```
#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  

Implements [CalculateTotal()](https://docs.microsoft.com/en-us/dotnet/api/Hedgehog.Core.Contracts.DomainContracts.IShoppingCart.CalculateTotal 'Hedgehog.Core.Contracts.DomainContracts.IShoppingCart.CalculateTotal')  
