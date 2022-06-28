using System.Collections.Generic;

namespace ProjSem_Sklep_Lib.Models
{
    public class Order : BaseModel
    {
        /// <summary>
        /// Propercja przechowywująca date składanego zamówienia
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Propercja przechowywująca całkowitą sumę złożonego zamówienia
        /// </summary>
        public decimal SumPrice { get; set; }

        /// <summary>
        /// Propercja przechowywująca kolekcje produktów 
        /// </summary>
        public ICollection<Product> Products { get; set; }

        /// <summary>
        /// Propercja przechowywująca tablicę relacji pomiędzy produktami a zamówieniem
        /// </summary>
        public List<ProductOrder> ProductOrders { get; set; }
    }
}
