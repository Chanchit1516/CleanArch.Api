using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Infrastructure.Data;
using CleanArch.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.EFCore
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly ApplicationDbContext _dbContext;
        private bool _disposed;
        IProductRepository productRepository;
        ICustomerRepository customerRepository;
        IOrderRepository orderRepository;


        //private readonly ILogger _logger;

        public UnitOfWork(ApplicationDbContext context, ILoggerFactory loggerFactory)
        {
            _dbContext = context;
        }


        public IProductRepository ProductRepository => productRepository ??= new ProductRepository(_dbContext);
        public ICustomerRepository CustomerRepository => customerRepository ??= new CustomerRepository(_dbContext);
        public IOrderRepository OrderRepository => orderRepository ??= new OrderRepository(_dbContext);


        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext?.Dispose();
        }
    }
}
