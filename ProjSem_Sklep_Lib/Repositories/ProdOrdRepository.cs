using Microsoft.EntityFrameworkCore;
using ProjSem_Sklep_Lib.Models;
using System.Linq;

namespace ProjSem_Sklep_Lib.Repositories
{
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
