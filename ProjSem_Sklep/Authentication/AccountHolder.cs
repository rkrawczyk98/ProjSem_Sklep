using ProjSem_Sklep.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep.Authentication
{
    public class CredentialsHolder
    {
        private readonly UserViewModel _user;

        public int ID => _user.ID;

        public bool IsAdmin => _user.IsAdmin;

        public CredentialsHolder(UserViewModel user)
        {
            _user = user;
        }
    }
}
