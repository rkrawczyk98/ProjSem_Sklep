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

        /// <summary>
        /// Metoda dodająca element do bazy danych
        /// </summary>
        /// <param name="item"></param>
        public virtual void Add(T item)
        {
            _dbSet.Add(item);
        }

        /// <summary>
        /// Metoda zwracająca wszystkie elementy z tablicy
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        /// <summary>
        /// Metoda wyszukująca elementy po ich ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        /// <summary>
        /// Metoda wyszukująca ostatni element w tablicy
        /// </summary>
        /// <returns></returns>
        public virtual T GetLast()
        {
            return _dbSet.Last();
        }

        /// <summary>
        /// Metoda usuwająca element z tablicy
        /// </summary>
        /// <param name="item"></param>
        public virtual void Remove(T item)
        {
            if(item != null)
                _dbSet.Remove(item);
            
        }

        /// <summary>
        /// Metoda zapisująca zmiany w tablicy
        /// </summary>
        public virtual void Save()
        {
            _dbContext.SaveChanges();
        }

        /// <summary>
        /// Metoda modyfikująca dane 
        /// </summary>
        /// <param name="itemChanges"></param>
        public virtual void Update(T itemChanges)
        {
            var item = _dbSet.Attach(itemChanges);
            item.State = EntityState.Modified;
            Save();
        }
    }
}
