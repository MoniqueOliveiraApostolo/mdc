using System.Collections.Generic;
using MDC.Domain.Entities;

namespace MDC.Domain.Interfaces.Repository
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        
            Product GetById(string id);
            IEnumerable<Product> GetAll();
    }
}