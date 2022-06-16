using Microsoft.EntityFrameworkCore;
using ProjSem_Sklep_Lib.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjSem_Sklep_Lib.Repositories
{
    public class OrderRepository : BaseRepository<Order>
    {
        public OrderRepository(DbContext dbContext) : base(dbContext)
        {
        }


        public override IEnumerable<Order> GetAll()
        {
            return _dbSet.Include(x => x.Products).ToList();
        }

        public class ProdOrdRepository : BaseRepository<ProductOrder>
        {
            public ProdOrdRepository(DbContext dbContext) : base(dbContext)
            {
            }

            public ProductOrder? GetByKeys(int prodID, int ordID)
            {
                return GetAll().SingleOrDefault(x => x.ProductId == prodID && x.OrderId == ordID);
            }
        }
    }
}
