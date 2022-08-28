﻿using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Application.Mappers;
using CleanArch.Application.Services;
using CleanArch.Domain.DTOs.Customers;
using CleanArch.Domain.Entities;
using MediatR;

namespace CleanArch.Application.Handlers.Customers.Queries
{
    public class GetAllCustomerTableQueryHandler : IRequestHandler<GetAllCustomerTableQuery, List<CustomerResponseDTO>>
    {
        private IUnitOfWork _unitOfWork;
        private ICustomerService _customerService;

        public GetAllCustomerTableQueryHandler(IUnitOfWork unitOfWork, ICustomerService customerService)
        {
            _unitOfWork = unitOfWork;
            _customerService = customerService;
        }

        public async Task<List<CustomerResponseDTO>> Handle(GetAllCustomerTableQuery request, CancellationToken cancellationToken)
        {
            var query = _unitOfWork.CustomerRepository.GetAll();
            //var querys =
            //    from c in _unitOfWork.CustomerRepository.Query()
            //    join p in _unitOfWork.OrderRepository.Query() on c.Id equals p.CustomerId
            //    select new 
            //    {
            //        ContactTitle = c.ContactTitle,
            //        CompanyName = c.CompanyName,
            //        ShippedDate = p.ShippedDate
            //    };
            var result =  ObjectMapper.Mapper.Map<List<CustomerResponseDTO>>(query);
            return result;
        }
    }
}
