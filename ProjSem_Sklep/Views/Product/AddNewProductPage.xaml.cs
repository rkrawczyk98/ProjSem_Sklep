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

namespace ProjSem_Sklep.Views.Product
{
    /// <summary>
    /// Interaction logic for AddNewProductPage.xaml
    /// </summary>
    public partial class AddNewProductPage : Page
    {
        private MainWindow _mainWin;
        private ProductWindow _prodWin;
        private RepositoryHolder _repoHolder;

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public AddNewProductPage(MainWindow mainWin, ProductWindow prodWin, RepositoryHolder repoHolder)
        {
            _mainWin = mainWin;
            _repoHolder = repoHolder;
            _prodWin = prodWin;
            DataContext = this;
            InitializeComponent();
        }

        private void Zapisz_Button_Click(object sender, RoutedEventArgs e)
        {
            var nowyProdukt = new EFProduct() { Name = this.Name, Quantity = this.Quantity, Price = this.Price };
            _repoHolder.ProdRepo.Add(nowyProdukt);
            _repoHolder.ProdRepo.Save();
            DataContext = _mainWin;
            _prodWin.Close();
        }

        private void Anuluj_Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = _mainWin;
            _prodWin.Close();
        }
    }
}
