using System;
using System.Collections.Generic;
using System.Text;
using MDC.DAL.Context;
using MDC.Domain.Entities;
using MDC.Domain.Interfaces.Repository;

namespace MDC.DAL.Repository
{
    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        public CountryRepository(ContextMDC context) : base(context)
        {
        }

        public Country GetById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
