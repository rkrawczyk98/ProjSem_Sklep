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

        /// <summary>
        /// Metoda wyszukująca użytkownia po loginie i haśle
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public User? FindUser(string login, string password)
        {
            return GetAll().FirstOrDefault(x => x.Login == login && x.Password == password);
        }

        /// <summary>
        /// Metoda wyszukująca użytkownika po loginie
        /// </summary>
        /// <param name="login"></param>
        /// <returns></returns>
        public User? FindUser(string login)
        {
            return GetAll().FirstOrDefault(x => x.Login == login);
        }
    }
}
