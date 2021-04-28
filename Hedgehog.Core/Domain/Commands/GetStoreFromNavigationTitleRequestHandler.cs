using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    /// <summary>
    /// Handles a request for a WebStore based on the navigation title - the part of the URL in the UI that
    /// identifies a store.
    /// </summary>
    public class GetStoreFromNavigationTitleRequestHandler :
        IRequestHandler<GetStoreFromNavigationTitleRequest, WebStore>
    {
        private readonly IWebStoreRepository _webStoreRpository;
        public GetStoreFromNavigationTitleRequestHandler(IWebStoreRepository webStoreRpository)
        {
            _webStoreRpository = webStoreRpository;
        }

        public async Task<WebStore> Handle(GetStoreFromNavigationTitleRequest request, CancellationToken cancellationToken)
        {
            return await _webStoreRpository.GetWebStoreFromNavigationTitle(request.NavigationTitle);
        }
    }
}
