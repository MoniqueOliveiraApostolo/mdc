using System;
using System.Collections.Generic;
using System.Text;

namespace MDC.Domain.Entities
{
    public class State : EntityBase
    {
        public Country Country { get; set; }
        public virtual IEnumerable<City> Cities { get; set; }
    }
}
