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

        /// <summary>
        /// Zwraca wszystkich studentów razem z ich powiązanymi grupami
        /// </summary>
        /// <returns>IEnumerable encji typu Student</returns>
        public override IEnumerable<Order> GetAll()
        {
            return _dbSet.Include(x => x.Products).ToList();
        }

        public class ProdOrdRepository : BaseRepository<ProductOrder>
        {
            public ProdOrdRepository(DbContext dbContext) : base(dbContext)
            {
            }

            /// <summary>
            /// Wyszukuje encję o podanym kluczu (ID nauczyciela oraz ID grupy)
            /// </summary>
            /// <param name="teaID">ID nauczyciela</param>
            /// <param name="groupID">ID grupy</param>
            /// <returns>Zwraca encję typu GroupTeacher, jeżeli nie istnieje zwraca null </returns>
            public ProductOrder? GetByKeys(int prodID, int ordID)
            {
                return GetAll().SingleOrDefault(x => x.ProductId == prodID && x.OrderId == ordID);
            }
        }
    }
}
