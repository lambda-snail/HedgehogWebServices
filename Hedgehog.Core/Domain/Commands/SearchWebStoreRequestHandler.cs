using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    public class SearchWebStoreRequestHandler : IRequestHandler<SearchWebStoreRequest, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMediator _mediator;

        public SearchWebStoreRequestHandler(IProductRepository productRepository, IMediator mediator)
        {
            _productRepository = productRepository;
            _mediator = mediator;
        }

        public async Task<IEnumerable<Product>> Handle(SearchWebStoreRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrWhiteSpace(request.SearchString))
            {
                return await _mediator.Send(new GetProductsFromStoreRequest { StoreId = request.StoreId });
            }            
            else
            {
                return await _productRepository.SearchProductsFromWebStoreAsync(request.StoreId, request.SearchString);
            }
        }
    }
}
