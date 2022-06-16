using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Context
{
    public class InMemoryDbContext : BaseDbContext
    {
        public InMemoryDbContext() : base()
        {
            Database.EnsureCreated();
        }
    }
}
