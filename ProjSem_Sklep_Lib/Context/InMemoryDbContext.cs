using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Context
{
    public class InMemoryDbContext : BaseDbContext
    {
        /// <summary>
        /// Baza danych w pamięci służąca do testowania aplikacji
        /// </summary>
        public InMemoryDbContext() : base()
        {
            Database.EnsureCreated();
        }
    }
}
