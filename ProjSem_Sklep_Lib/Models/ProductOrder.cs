namespace ProjSem_Sklep_Lib.Models
{
    /// <summary>
    /// Klasa określająca relację dla zamówień i produktów
    /// </summary>
    public class ProductOrder 
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
