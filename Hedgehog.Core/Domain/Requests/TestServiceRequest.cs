using Hedgehog.Core.Contracts;
using MediatR;

namespace Hedgehog.Core.Domain.Requests
{
    public class TestServiceRequest : IRequest<ITestService>
    {
    }
}
