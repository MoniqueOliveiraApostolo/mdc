using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MDC.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);
       void Update(T obj);
        void Remove(string id);
        int SaveChanges();
    }
}
