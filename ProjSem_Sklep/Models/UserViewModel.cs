using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep.Models
{
    public class UserViewModel : BaseViewModel
    {
        /// <summary>
        /// Nazwa użytkownika
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Hasło do konta
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Zmienna określająca czy dany użytkownik jest administratorem
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
