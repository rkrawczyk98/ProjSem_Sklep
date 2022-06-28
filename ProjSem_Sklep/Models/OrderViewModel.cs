namespace ProjSem_Sklep.Models
{
    public class OrderViewModel : BaseViewModel
    {
        /// <summary>
        /// Data utworzenia zamówienia
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Całkowita kwota złożonego zamówienia
        /// </summary>
        public decimal SumPrice { get; set; }

    }
}
