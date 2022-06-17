using Microsoft.EntityFrameworkCore;
using ProjSem_Sklep_Lib.Models;
using System.Linq;

namespace ProjSem_Sklep_Lib.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public UserRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public User? FindUser(string login, string password)
        {
            return GetAll().FirstOrDefault(x => x.Login == login && x.Password == password);
        }

        public User? FindUser(string login)
        {
            return GetAll().FirstOrDefault(x => x.Login == login);
        }
    }
}
