using Microsoft.EntityFrameworkCore;
using ProjSem_Sklep_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjSem_Sklep_Lib.Repositories
{
    public class ProductRepository : BaseRepository<Product>
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Product> GetAll()
        {
            return _dbSet.Include(x => x.Orders).ToList();
        }
    }
}
