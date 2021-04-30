using Autofac;
using Hedgehog.Core.Contracts.InfrastructureContracts;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Hedgehog.Infrastructure.Services
{
    public class JsonSerializer<T> : ISerializer<T>
    {
        private readonly AutofacContractResolver _contractResolver;
        public JsonSerializer(ILifetimeScope container)
        {
            _contractResolver = new(container);
        }

        public T Deserialize(string stringEntity)
        {
            //return JsonConvert.DeserializeObject<T>(stringEntity);

            return JsonConvert.DeserializeObject<T>(stringEntity, new JsonSerializerSettings
            {
                ContractResolver = _contractResolver
            });
        }

        public async Task<T> DeserializeAsync(string stringEntity)
        {
            return await Task<string>.Run(() => Deserialize(stringEntity));
        }

        public string Serialize(T entity)
        {
            //return JsonConvert.SerializeObject(entity, Formatting.None);
            return JsonConvert.SerializeObject(entity, Formatting.None, new JsonSerializerSettings
              {
                  ContractResolver = _contractResolver
              });
        }

        public async Task<string> SerializeAsync(T entity)
        {
            return await Task<string>.Run(() => Serialize(entity));
        }
    }
}
