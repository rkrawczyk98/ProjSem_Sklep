namespace ProjSem_Sklep.Models
{
    public class ProductOrderViewModel
    {
        /// <summary>
        /// Id produktu przypisywanego do zamówienia
        /// </summary>
        public int ProductId { get; set; }
        /// <summary>
        /// Id produktu oznaczające numer zamówienia do ktorego przypisuje produkty
        /// </summary>
        public int OrderId { get; set; }
    }
}
