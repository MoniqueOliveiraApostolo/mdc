using System.Collections.Generic;
using MDC.Domain.Entities;

namespace MDC.Domain.Interfaces.Repository
{
    public interface ICategoryRepository : IRepositoryBase<Category>
    {
        Category GetById(string id);
        IEnumerable<Category> GetAll();
    }
}