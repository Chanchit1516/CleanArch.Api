using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Application.Services;
using CleanArch.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Handlers.Customers.Commands
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private IUnitOfWork _unitOfWork;
        private ICustomerService _customerService;

        public CreateCustomerCommandHandler(IUnitOfWork unitOfWork, ICustomerService customerService)
        {
            _unitOfWork = unitOfWork;
            _customerService = customerService;
        }

        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var newCustomer = new Customer();
            newCustomer.CompanyName = request.CompanyName;
            newCustomer.ContactTitle = request.ContactTitle;
            newCustomer.Phone = request.Phone;
            newCustomer.Country = request.Country;

            _unitOfWork.CustomerRepository.Add(newCustomer);
            _unitOfWork.Commit();

            return Unit.Value;
        }
    }
}
