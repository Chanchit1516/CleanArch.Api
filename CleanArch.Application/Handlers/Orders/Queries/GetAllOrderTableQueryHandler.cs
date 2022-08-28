using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Application.Mappers;
using CleanArch.Domain.DTOs.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Handlers.Orders.Queries
{
    public class GetAllOrderTableQueryHandler : IRequestHandler<GetAllOrderTableQuery, List<OrderResponseDTO>>
    {
        private IUnitOfWork _unitOfWork;
        public GetAllOrderTableQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<List<OrderResponseDTO>> Handle(GetAllOrderTableQuery request, CancellationToken cancellationToken)
        {
            var query = _unitOfWork.OrderRepository.GetAll();

            var result = ObjectMapper.Mapper.Map<List<OrderResponseDTO>>(query);
            return result;
        }
    }
}
