using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Handlers.Products.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private IUnitOfWork _unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var newProduct = new Product();
            newProduct.ProductName = request.ProductName;
            newProduct.UnitPrice = request.UnitPrice;
            newProduct.UnitsInStock = request.UnitsInStock;
            newProduct.UnitsOnOrder = request.UnitsOnOrder;
            newProduct.Barcode = request.Barcode;
            newProduct.OrderId = request.OrderId;

            _unitOfWork.ProductRepository.Add(newProduct);
            _unitOfWork.Commit();

            return Unit.Value;
        }
    }
}
