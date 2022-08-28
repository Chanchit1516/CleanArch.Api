using CleanArch.Domain.DTOs.Orders;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Handlers.Orders.Queries
{
    public class GetAllOrderTableQuery : IRequest<List<OrderResponseDTO>>
    {

    }
}
