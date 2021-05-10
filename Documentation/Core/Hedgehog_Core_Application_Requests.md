#### [Hedgehog.Core](index.md 'index')
## Hedgehog.Core.Application.Requests Namespace
### Classes

***
[GetCustomerWithNavigationPropertiesRequest](Hedgehog_Core_Application_Requests_GetCustomerWithNavigationPropertiesRequest.md 'Hedgehog.Core.Application.Requests.GetCustomerWithNavigationPropertiesRequest')

The built-in UserManager does not load navigation properties. This class makes a request  
to ensure that these are loaded, and should be used when needed. If not needed, the normal  
way to get user information via UserManager is preferred.  
