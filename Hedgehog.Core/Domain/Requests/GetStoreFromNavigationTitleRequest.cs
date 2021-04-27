using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Requests
{
    public class GetStoreFromNavigationTitleRequest : IRequest<WebStore>
    {
        public string NavigationTitle { get; set; }
    }
}
