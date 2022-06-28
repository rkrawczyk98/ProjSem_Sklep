using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Models
{
    public abstract class BaseModel : IEntity
    {
        /// <summary>
        /// Propercja przypisująca Id do klas które dziedziczą po BaseModel - tj. Order, Product oraz User
        /// </summary>
        public int ID { get; set; }
    }
}
