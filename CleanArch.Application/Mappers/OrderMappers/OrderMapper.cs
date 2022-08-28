using CleanArch.Domain.DTOs.Orders;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mappers.OrderMappers
{
    public class OrderMapper : AutoMapper.Profile
    {
        public OrderMapper()
        {
            CreateMap<Order, OrderResponseDTO>().ReverseMap();
        }
    }
}
