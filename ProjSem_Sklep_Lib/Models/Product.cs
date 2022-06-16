using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep_Lib.Models
{
    public class Product : BaseModel
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public ICollection<Order> Orders { get; set; }

        public List<ProductOrder> ProductOrders { get; set; }
    }
}
