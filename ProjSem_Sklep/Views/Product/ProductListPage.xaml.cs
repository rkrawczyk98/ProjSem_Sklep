using ProjSem_Sklep_Lib.Repositories;
using System;
using EFProduct = ProjSem_Sklep_Lib.Models.Product;
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
using ProjSem_Sklep.Views.ShoppingList;
using ProjSem_Sklep.Views.Orders;
using ProjSem_Sklep.Views.Users;

namespace ProjSem_Sklep.Views.Product
{
    /// <summary>
    /// Interaction logic for ProductListPage.xaml
    /// </summary>
    public partial class ProductListPage : Page
    {
        private MainWindow _mainWindow;
        private RepositoryHolder _repoHolder;

        public List<EFProduct> ProductList { get; set; }

        public EFProduct SelectedProduct { get; set; }

        public ProductListPage(MainWindow mainWin, RepositoryHolder repoHolder)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            DataContext = this;
            ProductList = (List<EFProduct>)_repoHolder.ProdRepo.GetAll();
            InitializeComponent();
        }

        private void DodajDoKoszyka_Button_Click(object sender, RoutedEventArgs e)
        {
            LoginPage.Koszyk.Products.Add(SelectedProduct);
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

        private void Usuna_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edytuj_Button_Click(object sender, RoutedEventArgs e)
        {
            var productWindow = new ProductWindow();
            productWindow.Content = new EditProductPage(_mainWindow,productWindow, _repoHolder, SelectedProduct);
            productWindow.Show();
        }

        private void Dodaj_Button_Click(object sender, RoutedEventArgs e)
        {
            var productWindow = new ProductWindow();
            productWindow.Content = new AddNewProductPage(_mainWindow, productWindow, _repoHolder);
            productWindow.Show();
        }
    }
}
