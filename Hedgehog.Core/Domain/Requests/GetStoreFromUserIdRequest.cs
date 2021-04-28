using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    public class GetStoreFromUserIdRequest : IRequest<WebStore>
    {
        public string UserId { get; set; }
    }
}
