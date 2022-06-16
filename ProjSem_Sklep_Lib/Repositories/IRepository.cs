using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Repositories
{
    public interface IRepository<T> where T : class
    {
        T GetLast();

        void Add(T item);

        void Remove(T item);

        void Save();

        void Update(T item);

        IEnumerable<T> GetAll();

        T GetById(int id);

    }
}
