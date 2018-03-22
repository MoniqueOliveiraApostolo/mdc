using System;
using System.Collections.Generic;
using System.Text;
using MDC.DAL.Context;
using MDC.Domain.Entities;
using MDC.Domain.Interfaces.Repository;

namespace MDC.DAL.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(ContextMDC context) : base(context)
        {
        }

        public Category GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
