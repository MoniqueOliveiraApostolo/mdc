using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MDC.DAL.Context;
using MDC.DAL.Seed;
using MDC.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;

namespace MDC.DAL.Repository
{
    public class Repository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly ContextMDC Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(ContextMDC context)
        {
            Db = context;
            if ((context.Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
            {
                Db.Database.EnsureCreated();
                
            }
            
            DbSet = Db.Set<TEntity>();
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public TEntity GetById(string id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(string id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
