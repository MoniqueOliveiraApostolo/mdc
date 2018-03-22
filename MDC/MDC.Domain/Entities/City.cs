using System;
using System.Collections.Generic;
using System.Text;

namespace MDC.Domain.Entities
{
    public class City : EntityBase
    {
        public virtual State State { get; set; }
        
    }
}
