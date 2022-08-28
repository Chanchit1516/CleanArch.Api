using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Services
{
    public class CustomerService : ICustomerService
    {
        public int GetSum()
        {
            return 1 + 2;
        }
    }
}
