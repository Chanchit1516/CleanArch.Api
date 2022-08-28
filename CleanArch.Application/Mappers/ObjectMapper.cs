using AutoMapper;
using CleanArch.Application.Mappers.CustomerMappers;
using CleanArch.Application.Mappers.OrderMappers;
using CleanArch.Application.Mappers.ProductMappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Mappers
{
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<CustomerMapper>();
                cfg.AddProfile<OrderMapper>();
                cfg.AddProfile<ProductMapper>();
            });

            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
}
