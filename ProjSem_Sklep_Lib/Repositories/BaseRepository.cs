using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjSem_Sklep_Lib.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly DbContext _dbContext;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }

        public virtual void Add(T item)
        {
            _dbSet.Add(item);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public T GetLast()
        {
            return _dbSet.Last();
        }

        public virtual void Remove(T item)
        {
            _dbSet.Remove(item);
        }

        public virtual void Save()
        {
            _dbContext.SaveChanges();
        }

        public virtual void Update(T itemChanges)
        {
            var item = _dbSet.Attach(itemChanges);
            item.State = EntityState.Modified;
            Save();
        }
    }
}
