using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Models
{
    public class Product : BaseModel
    {
        /// <summary>
        /// Propercja przechowywująca nazwę produktu
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Propercja przechowywująca ilość danego produktu w magazynie
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Propercja przechowywująca cenę danego produktu
        /// </summary>
        public decimal Price { get; set; }


        public ICollection<Order> Orders { get; set; }


        public List<ProductOrder> ProductOrders { get; set; }
    }
}
