using CleanArch.Domain.DTOs.Customers;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Handlers.Customers.Queries
{
    public class GetAllCustomerTableQuery : IRequest<List<CustomerResponseDTO>>
    {

    }
}
