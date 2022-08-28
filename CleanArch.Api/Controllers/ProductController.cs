using CleanArch.Application.Handlers.Products.Commands;
using CleanArch.Application.Handlers.Products.Queries;
using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Domain.DTOs.Products;
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
    public class ProductController : Controller
    {
        private IMediator _mediator;
        private IUnitOfWork _unitOfWork;
        public ProductController(IMediator mediator, IUnitOfWork unitOfWork)
        {
            _mediator = mediator;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ResponseResult<List<ProductResponseDTO>>> GetAllProduct()
        {
            var result = await _mediator.Send(new GetAllProductTableQuery());
            return ResponseResult<List<ProductResponseDTO>>.Success(result);
        }

        [HttpPost]
        public async Task<ResponseResult<string>> InsertProduct([FromBody] CreateProductCommand request)
        {
            var result = await _mediator.Send(request);
            return ResponseResult<string>.Success();
        }
    }
}
