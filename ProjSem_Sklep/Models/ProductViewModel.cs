namespace ProjSem_Sklep.Models
{
    public class ProductViewModel : BaseViewModel
    {
        /// <summary>
        /// Nazwa produktu
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ilość produktu dostępnego w magazynie
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Cena jednego produktu
        /// </summary>
        public decimal Price { get; set; }
    }
}
