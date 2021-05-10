#### [Hedgehog.Core](index.md 'index')
## Hedgehog.Core.Domain.Commands Namespace
### Classes

***
[AddOrUpdateOrderRequestHandler](Hedgehog_Core_Domain_Commands_AddOrUpdateOrderRequestHandler.md 'Hedgehog.Core.Domain.Commands.AddOrUpdateOrderRequestHandler')

Adds a new Order to the system or updates an existing. The new or updated order is returned after execution.  

***
[CreateOrderRequestHandler](Hedgehog_Core_Domain_Commands_CreateOrderRequestHandler.md 'Hedgehog.Core.Domain.Commands.CreateOrderRequestHandler')

This command handler takes care of everything that is needed to create an order based on a shopping cart  
and is the prefferred way to do so.  
  
Any order items with an amount of 0 will be ignored.  

***
[GetAllOrdersByCustomerIdRequestHandler](Hedgehog_Core_Domain_Commands_GetAllOrdersByCustomerIdRequestHandler.md 'Hedgehog.Core.Domain.Commands.GetAllOrdersByCustomerIdRequestHandler')

Retreives all orders in the DB for a given customer.  

***
[GetStoreFromNavigationTitleRequestHandler](Hedgehog_Core_Domain_Commands_GetStoreFromNavigationTitleRequestHandler.md 'Hedgehog.Core.Domain.Commands.GetStoreFromNavigationTitleRequestHandler')

Handles a request for a WebStore based on the navigation title - the part of the URL in the UI that  
identifies a store.  
