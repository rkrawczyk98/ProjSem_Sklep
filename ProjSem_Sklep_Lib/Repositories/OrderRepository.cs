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
        /// Metoda zwracająca zamówienia wraz z ich relacjami
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Order> GetAll()
        {
            return _dbSet.Include(x => x.Products).ToList();
        }    

        /// <summary>
        /// Metoda zwracająca ostatnie zamówienie
        /// </summary>
        /// <returns></returns>
        public override Order GetLast()
        {
            return _dbSet.OrderBy(x => x.ID).Last();
        }
    }
}
