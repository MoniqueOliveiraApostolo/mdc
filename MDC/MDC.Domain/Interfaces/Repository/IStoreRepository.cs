using System.Collections.Generic;
using MDC.Domain.Entities;

namespace MDC.Domain.Interfaces.Repository
{
    public interface IStoreRepository : IRepositoryBase<Store>
    {

            Store GetById(string id);
            IEnumerable<Store> GetAll();
    }
}