using CleanArch.Domain.DTOs.Customers;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mappers.CustomerMappers
{
    public class CustomerMapper : AutoMapper.Profile
    {
        public CustomerMapper()
        {
            CreateMap<Customer, CustomerResponseDTO>().ReverseMap();
        }
    }
}
