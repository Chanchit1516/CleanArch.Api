using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.Handlers.Products.Commands
{
    public class CreateProductCommand : IRequest
    {
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int UnitPrice { get; set; }
        [Required]
        public int UnitsInStock { get; set; }
        [Required]
        public int UnitsOnOrder { get; set; }
        public string Barcode { get; set; }
        [Required]
        public int OrderId { get; set; }
    }
}
