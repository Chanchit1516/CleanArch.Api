using CleanArch.Domain.DTOs.Products;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Handlers.Products.Queries
{
    public class GetAllProductTableQuery : IRequest<List<ProductResponseDTO>>
    {
    }
}
