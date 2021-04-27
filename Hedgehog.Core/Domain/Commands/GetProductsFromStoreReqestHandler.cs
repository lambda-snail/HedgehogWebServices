using Hedgehog.Core.Contracts.InfrastructureContracts.Repositories;
using Hedgehog.Core.Domain.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hedgehog.Core.Domain.Commands
{
    public class GetProductsFromStoreReqestHandler : IRequestHandler<GetProductsFromStoreRequest, IEnumerable<Product>>
    {
        private readonly IProductRepository _productRepository;

        public GetProductsFromStoreReqestHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> Handle(GetProductsFromStoreRequest request, CancellationToken cancellationToken)
        {
            return await _productRepository.GetProductsFromWebStoreIdAsync(request.StoreId);
        }
    }
}
