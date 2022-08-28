using CleanArch.Domain.DTOs.Products;
using CleanArch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mappers.ProductMappers
{
    public class ProductMapper : AutoMapper.Profile
    {
        public ProductMapper()
        {
            CreateMap<Product, ProductResponseDTO>().ReverseMap();
        }
    }
}
