﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.DTOs.Customers
{
    public class CustomerResponseDTO
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }
    }
}
