using ProjSem_Sklep.Views.Orders;
using ProjSem_Sklep.Views.Product;
using EFProduct = ProjSem_Sklep_Lib.Models.Product;
using ProjSem_Sklep.Views.Users;
using ProjSem_Sklep_Lib.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProjSem_Sklep.Views.Login_Register;
using ProjSem_Sklep_Lib.Models;

namespace ProjSem_Sklep.Views.ShoppingList
{
    /// <summary>
    /// Interaction logic for ShoppingListPage.xaml
    /// </summary>
    public partial class ShoppingListPage : Page
    {
        private MainWindow _mainWindow;
        private RepositoryHolder _repoHolder;

        public List<EFProduct> ShoppingList { get; set; }
        public EFProduct SelectedProduct { get; set; }

        public ShoppingListPage(MainWindow mainWin, RepositoryHolder repoHolder)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            DataContext = this;
            ShoppingList = LoginPage.Koszyk.Products;
            InitializeComponent();
        }

        private void Zamow_Button_Click(object sender, RoutedEventArgs e)
        {
            
            int priceSum = 0;

            foreach (var item in ShoppingList)
            {
                priceSum += (int)item.Price * item.Quantity;
            }
            var order = new Order() { Date = DateTime.Now.ToString(), SumPrice = priceSum };
            _repoHolder.OrdRepo.Add(order);
            _repoHolder.OrdRepo.Save();

            foreach (var item in ShoppingList)
            {
                _repoHolder.ProdOrdRepo.Add(new ProductOrder() { OrderId = _repoHolder.OrdRepo.GetLast().ID, ProductId = item.ID });
            }
            _repoHolder.ProdOrdRepo.Save();
        }

        private void ProductList_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listbox = (ListBox)sender;
            var item = (EFProduct)listbox.SelectedItem;
            SelectedProduct = item;
        }

        private void Koszyk_Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Content = new ShoppingListPage(_mainWindow, _repoHolder);
        }

        private void Produkty_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Content = new ProductListPage(_mainWindow, _repoHolder);
        }

        private void Zamowienia_Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Content = new OrdersListPage(_mainWindow, _repoHolder);
        }

        private void Uzytkownicy_Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Content = new UsersListPage(_mainWindow, _repoHolder);
        }

        private void Usun_Button_Click(object sender, RoutedEventArgs e)
        {
            ShoppingList.Remove(SelectedProduct);
            LoginPage.Koszyk.Products.Remove(SelectedProduct);
            ShoppingList_ListBox.Items.Refresh();
        }
    }
}
