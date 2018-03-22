using System;
using System.Collections.Generic;
using System.Text;

namespace MDC.Domain.Entities
{
    public class Store : EntityBase
    {
        public virtual IEnumerable<Category> Categories { get; set; }
    }
}
