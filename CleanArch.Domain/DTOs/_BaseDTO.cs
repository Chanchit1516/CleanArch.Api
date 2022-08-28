using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.DTOs
{
    public class _BaseDTO
    {
        public _BaseDTO()
        {
            //CreatedDateTime = DateTimeHelper.Now();
        }
        public DateTime CreatedDateTime { get; set; }
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
