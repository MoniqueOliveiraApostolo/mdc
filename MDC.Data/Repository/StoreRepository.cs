using System;
using System.Collections.Generic;
using System.Text;
using MDC.DAL.Context;
using MDC.Domain.Entities;
using MDC.Domain.Interfaces.Repository;

namespace MDC.DAL.Repository
{
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(ContextMDC context) : base(context)
        {
        }

        public Store GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
