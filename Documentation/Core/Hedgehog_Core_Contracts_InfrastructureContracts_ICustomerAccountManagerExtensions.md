#### [Hedgehog.Core](index.md 'index')
### [Hedgehog.Core.Contracts.InfrastructureContracts](Hedgehog_Core_Contracts_InfrastructureContracts.md 'Hedgehog.Core.Contracts.InfrastructureContracts')
## ICustomerAccountManagerExtensions Interface
The built-in UserManager does not load navigation properties. This class provides a method  
to load users including navigation properties, when they are needed. If not needed, the normal  
way to get user information via UserManager is preferred.  
  
It is intended to be injected into request handlers that need it.  
```csharp
public interface ICustomerAccountManagerExtensions
```
