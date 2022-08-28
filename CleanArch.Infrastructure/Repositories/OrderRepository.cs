using CleanArch.Application.Interfaces.Repositories;
using CleanArch.Domain.Entities;
using CleanArch.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.Repositories
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext db) : base(db)
        { }

    }
}
