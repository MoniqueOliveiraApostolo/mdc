using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MDC.DAL.Context;
using MDC.Domain.Entities;
using MDC.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace MDC.DAL.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ContextMDC context) : base(context)
        {
            
        }

    }
}
