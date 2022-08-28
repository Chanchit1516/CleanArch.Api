using CleanArch.Application.Handlers.Orders.Commands;
using CleanArch.Application.Handlers.Orders.Queries;
using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Domain.DTOs.Orders;
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
    public class OrderController : Controller
    {
        private IMediator _mediator;
        private IUnitOfWork _unitOfWork;
        public OrderController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ResponseResult<List<OrderResponseDTO>>> GetAllOrder()
        {
            var result = await _mediator.Send(new GetAllOrderTableQuery());
            return ResponseResult<List<OrderResponseDTO>>.Success(result);
        }

        [HttpPost]
        public async Task<ResponseResult<string>> InsertOrder([FromBody] CreateOrderCommand request)
        {
            var result = await _mediator.Send(request);
            return ResponseResult<string>.Success();
        }

    }
}
