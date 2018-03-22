
using System.Collections.Generic;
using MDC.Domain.Entities;

namespace MDC.Domain.Interfaces.Repository
{
    public interface ICityRepository : IRepositoryBase<City>
    {
        
            City GetById(string id);
            IEnumerable<City> GetAll();
    }
}