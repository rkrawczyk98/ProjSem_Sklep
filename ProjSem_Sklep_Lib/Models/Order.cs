using System.Collections.Generic;

namespace ProjSem_Sklep_Lib.Models
{
    public class Order : BaseModel
    {
        public string Date { get; set; }

        public decimal SumPrice { get; set; }

        public ICollection<Product> Products { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }
}
