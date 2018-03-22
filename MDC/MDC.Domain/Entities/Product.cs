using System;
using System.Collections.Generic;
using System.Text;

namespace MDC.Domain.Entities
{
    public class Product : EntityBase
    {
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
      
    }
}
