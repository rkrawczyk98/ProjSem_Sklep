using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep.Models
{
    public class UserViewModel : BaseViewModel
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public bool IsAdmin { get; set; }
    }
}
