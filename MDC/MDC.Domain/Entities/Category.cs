using System;
using System.Collections.Generic;
using System.Text;

namespace MDC.Domain.Entities
{
    public class Category : EntityBase
    {
        public virtual IEnumerable<Product> Products { get; set; }

        public virtual Store store { get; set; }
    }
}
