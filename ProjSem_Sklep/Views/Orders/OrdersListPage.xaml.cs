using ProjSem_Sklep.Views.Product;
using ProjSem_Sklep.Views.ShoppingList;
using ProjSem_Sklep.Views.Users;
using ProjSem_Sklep_Lib.Models;
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

namespace ProjSem_Sklep.Views.Orders
{
    /// <summary>
    /// Interaction logic for OrdersListPage.xaml
    /// </summary>
    public partial class OrdersListPage : Page
    {
        private MainWindow _mainWindow;
        private RepositoryHolder _repoHolder;

        public List<Order> OrderList { get; set; }

        public OrdersListPage(MainWindow mainWin, RepositoryHolder repoHolder)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            DataContext = this;
            OrderList = (List<Order>)_repoHolder.OrdRepo.GetAll();
            InitializeComponent();
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
    }


}
