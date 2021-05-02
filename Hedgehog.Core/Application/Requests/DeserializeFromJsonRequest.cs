using MediatR;

namespace Hedgehog.Core.Application.Requests
{
    public class DeserializeFromJsonRequest<T> : IRequest<T>
    {
        public string Json { get; set; }
    }
}
