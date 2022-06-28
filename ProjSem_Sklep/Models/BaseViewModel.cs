using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep.Models
{
    public class BaseViewModel
    {
        /// <summary>
        /// ID przypisywane do klas które dziedziczą po BaseVieWModel - czyli OrderViewModel, ProductViewModel oraz UserViewModel
        /// </summary>
        public int ID { get; set; }
    }
}
