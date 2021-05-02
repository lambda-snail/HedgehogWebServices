using Autofac;
using Autofac.Core;
using Autofac.Core.Activators.Reflection;
using Newtonsoft.Json.Serialization;
using System;

namespace Hedgehog.Infrastructure.Services
{
    /// <summary>
    /// Allows serialization and deserialization of objects that have dependences which are resolved
    /// using Autofac.
    /// 
    /// Source: https://www.newtonsoft.com/json/help/html/DeserializeWithDependencyInjection.htm
    /// </summary>
    public class AutofacContractResolver : DefaultContractResolver
    {
        private readonly ILifetimeScope _container;

        public AutofacContractResolver(ILifetimeScope container)
        {
            _container = container;
        }

        protected override JsonObjectContract CreateObjectContract(Type objectType)
        {
            // use Autofac to create types that have been registered with it
            if (_container.IsRegistered(objectType))
            {
                JsonObjectContract contract = ResolveContact(objectType);
                contract.DefaultCreator = () => _container.Resolve(objectType);

                return contract;
            }

            return base.CreateObjectContract(objectType);
        }

        private JsonObjectContract ResolveContact(Type objectType)
        {
            // attempt to create the contact from the resolved type
            IComponentRegistration registration;
            if (_container.ComponentRegistry.TryGetRegistration(new TypedService(objectType), out registration))
            {
                Type viewType = (registration.Activator as ReflectionActivator)?.LimitType;
                if (viewType != null)
                {
                    return base.CreateObjectContract(viewType);
                }
            }

            // fall back to using the registered type
            return base.CreateObjectContract(objectType);
        }
    }
}
