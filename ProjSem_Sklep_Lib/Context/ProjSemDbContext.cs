using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Context
{
    public class ProjSemDbContext : BaseDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\LocalInstance;Database=ProjSem_Sklep;Trusted_Connection=True;MultipleActiveResultSets=true;trustServerCertificate=true");
        }
    }
}
