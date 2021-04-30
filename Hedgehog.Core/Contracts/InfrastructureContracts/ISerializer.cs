using System.Threading.Tasks;

namespace Hedgehog.Core.Contracts.InfrastructureContracts
{
    public interface ISerializer<T>
    {
        string Serialize(T entity);
        Task<string> SerializeAsync(T entity);
        T Deserialize(string stringEntity);
        Task<T> DeserializeAsync(string stringEntity);
    }
}
