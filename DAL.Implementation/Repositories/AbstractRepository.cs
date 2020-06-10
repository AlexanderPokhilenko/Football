using DAL.Abstract.Repositories;
using DAL.Entities;
using System;
using System.Collections.Generic;

namespace DAL.Implementation.Repositories
{
    public abstract class AbstractRepository<TKey, TEntity> : IRepository<TKey, TEntity>
        where TKey : struct where TEntity : class, IWithId<TKey>
    {
        protected readonly ApplicationContext Db;

        protected AbstractRepository(ApplicationContext context)
        {
            Db = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>();
        }

        public TEntity GetSingle(TKey id)
        {
            return Db.Find<TEntity>(id);
        }

        public void Create(TEntity item)
        {
            Db.Add(item);
            Db.SaveChanges();
        }

        public void Update(TEntity item)
        {
            Db.Update(item);
            Db.SaveChanges();
        }

        public void Delete(TKey id)
        {
            var result = Db.Find<TEntity>(id);
            Db.Remove(result);
        }

        public void Save()
        {
            Db.SaveChanges();
        }


        private bool _disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Db.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
