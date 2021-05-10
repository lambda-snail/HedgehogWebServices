#### [Hedgehog.Core](index.md 'index')
## Hedgehog.Core.Contracts.InfrastructureContracts Namespace
### Interfaces

***
[ICustomerAccountManagerExtensions](Hedgehog_Core_Contracts_InfrastructureContracts_ICustomerAccountManagerExtensions.md 'Hedgehog.Core.Contracts.InfrastructureContracts.ICustomerAccountManagerExtensions')

The built-in UserManager does not load navigation properties. This class provides a method  
to load users including navigation properties, when they are needed. If not needed, the normal  
way to get user information via UserManager is preferred.  
  
It is intended to be injected into request handlers that need it.  
