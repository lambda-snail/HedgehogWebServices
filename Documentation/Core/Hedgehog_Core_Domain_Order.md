#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Domain](Hedgehog_Core_Domain.md 'Hedgehog.Core.Domain')
## Order Class
```csharp
public class Order
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Order  
### Methods

***
[FinalizeOrder()](Hedgehog_Core_Domain_Order_FinalizeOrder().md 'Hedgehog.Core.Domain.Order.FinalizeOrder()')

Marks the order as complete.  

***
[GetOrderTotal()](Hedgehog_Core_Domain_Order_GetOrderTotal().md 'Hedgehog.Core.Domain.Order.GetOrderTotal()')

Returns the total of the order. This does not require a trip to the database.  

***
[IsCompletedTransaction()](Hedgehog_Core_Domain_Order_IsCompletedTransaction().md 'Hedgehog.Core.Domain.Order.IsCompletedTransaction()')

Returns true if and only if the transaction associated with this order is completed.  
