using Microsoft.EntityFrameworkCore;
using ProjSem_Sklep_Lib.Models;

namespace ProjSem_Sklep_Lib.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
