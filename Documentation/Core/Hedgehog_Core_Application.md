#### [Hedgehog.Core](index.md 'index')
## Hedgehog.Core.Application Namespace
### Classes

***
[GuardClause](Hedgehog_Core_Application_GuardClause.md 'Hedgehog.Core.Application.GuardClause')

Provides a fluent API for checking certain conditions on objects, such as if the reference is null.  
  
Usage:  
  GuardClause.Check.EnsureNotNull(myObject, "ErrorMsg")  
  GuardClause.Check.EnsureNotNull(myObject, "ErrorMsg").EnsureNotZero(myObject.IntProperty);  
  

***
[HedgehogUserAccount](Hedgehog_Core_Application_HedgehogUserAccount.md 'Hedgehog.Core.Application.HedgehogUserAccount')

Base class for user accounts in the application.   
Customers and users of the service will have a link to the related web store.  
Administrators will not be related to a store.  
