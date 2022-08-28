using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Application.Mappers;
using CleanArch.Domain.DTOs.Products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Handlers.Products.Queries
{
    public class GetAllProductTableQueryHandler : IRequestHandler<GetAllProductTableQuery, List<ProductResponseDTO>>
    {
        private IUnitOfWork _unitOfWork;

        public GetAllProductTableQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ProductResponseDTO>> Handle(GetAllProductTableQuery request, CancellationToken cancellationToken)
        {
            var query = _unitOfWork.ProductRepository.Query();

            var result = ObjectMapper.Mapper.Map<List<ProductResponseDTO>>(query);
            return result;
        }
    }
}
