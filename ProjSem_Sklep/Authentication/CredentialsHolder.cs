using ProjSem_Sklep.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep.Authentication
{
    public class CredentialsHolder
    {
        private readonly UserViewModel _user;

        /// <summary>
        /// Numer konta użytkownika
        /// </summary>
        public int ID => _user.ID;

        /// <summary>
        /// Zmienna sprawdzająca czy dany użytkownik jest administratorem
        /// </summary>
        public bool IsAdmin => _user.IsAdmin;

        /// <summary>
        /// Konstruktor przetrzymujący wybrane konto użytkownika
        /// </summary>
        /// <param name="user"></param>
        public CredentialsHolder(UserViewModel user)
        {
            _user = user;
        }
    }
}
