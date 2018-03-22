using System.Collections.Generic;
using MDC.Domain.Entities;

namespace MDC.Domain.Interfaces.Repository
{
    public interface ICountryRepository : IRepositoryBase<Country>
    {
        
            Country GetById(string id);
            IEnumerable<Country> GetAll();
    }
}