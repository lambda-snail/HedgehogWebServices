using Hedgehog.Core.Contracts.InfrastructureContracts;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Hedgehog.Infrastructure.Services
{
    public class JsonSerializer<T> : ISerializer<T>
    {
        public T Deserialize(string stringEntity)
        {
            return JsonConvert.DeserializeObject<T>(stringEntity);
        }

        public async Task<T> DeserializeAsync(string stringEntity)
        {
            return await Task<string>.Run(() => Deserialize(stringEntity));
        }

        public string Serialize(T entity)
        {
            return JsonConvert.SerializeObject(entity, Formatting.None);
        }

        public async Task<string> SerializeAsync(T entity)
        {
            return await Task<string>.Run(() => Serialize(entity));
        }
    }
}
