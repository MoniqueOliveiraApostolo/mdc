using System;
using System.Collections.Generic;
using System.Text;

namespace MDC.Domain.Entities
{
    public class Country : EntityBase
    {
        public virtual IEnumerable<State> States { get; set; }
    }
}
