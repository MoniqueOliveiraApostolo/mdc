using System.Collections.Generic;
using MDC.Domain.Entities;

namespace MDC.Domain.Interfaces.Repository
{
    public interface IStateRepository : IRepositoryBase<State>
    {
        
            State GetById(string id);
            IEnumerable<State> GetAll();
    }
}