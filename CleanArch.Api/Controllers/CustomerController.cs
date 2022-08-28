using CleanArch.Application.Handlers.Customers.Commands;
using CleanArch.Application.Handlers.Customers.Queries;
using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Domain.DTOs.Customers;
using CleanArch.Domain.Entities;
using CleanArch.SharedKernel.Enum;
using CleanArch.SharedKernel.ExceptionHandling;
using CleanArch.SharedKernel.Filters;
using CleanArch.SharedKernel.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiException]
    [ApiController]
    [ValidateModel]
    //[TypeFilter(typeof(BasicAuthenticationActionFilter), Order = 2, Arguments = new object[] { BasicAuthenticationSystem.CPM })]
    public class CustomerController : Controller
    {
        private IMediator _mediator;
        private IUnitOfWork _unitOfWork;
        public CustomerController(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ResponseResult<List<CustomerResponseDTO>>> GetAllCustomer()
        {

            var result = await _mediator.Send(new GetAllCustomerTableQuery());
            return ResponseResult<List<CustomerResponseDTO>>.Success(result);
        }

        [HttpPost]
        public async Task<ResponseResult<string>> InsertCustomer([FromBody] CreateCustomerCommand request)
        {
            var result = await _mediator.Send(request);
            return ResponseResult<string>.Success();
        }
    }
}
