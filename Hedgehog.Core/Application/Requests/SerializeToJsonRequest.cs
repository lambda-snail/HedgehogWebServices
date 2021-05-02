using MediatR;

namespace Hedgehog.Core.Application.Requests
{
    public class SerializeToJsonRequest<T> : IRequest<string>
    {
        public T Entity { get; set; }
    }
}
