using System;
using System.Collections.Generic;
using System.Text;
using MDC.DAL.Context;
using MDC.Domain.Entities;
using MDC.Domain.Interfaces.Repository;

namespace MDC.DAL.Repository
{
    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(ContextMDC context) : base(context)
        {
        }

        public City GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
