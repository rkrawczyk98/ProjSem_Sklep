using ProjSem_Sklep_Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjSem_Sklep.Models
{
    public class Koszyk
    {
        /// <summary>
        /// Lista produtków w koszyku
        /// </summary>
        public List<ProductViewModel> ShoppingList = new List<ProductViewModel>();

        /// <summary>
        /// Metoda umożliwiająca dodawanie produktów do koszyka, w sytuacji gdy dany produkt znajduje się już w koszyku,
        /// owa metoda przy dodawaniu zwięszka ilość danego produktu w koszyku o 1.
        /// </summary>
        /// <param name="product"></param>
        public void Add(Product product)
        {
            if (ShoppingList.Find(x => x.ID == product.ID) == null)
            {
                ShoppingList.Add(new ProductViewModel() { ID = product.ID, Name = product.Name, Price = product.Price, Quantity = 1 });
            }
            else
            {
                var productToIncrement = ShoppingList.Find(x => x.ID == product.ID);
                productToIncrement.Quantity++;
            }
        }
    }
}

