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
    /// Interaction logic for EditProductPage.xaml
    /// </summary>
    public partial class EditProductPage : Page
    {
        private MainWindow _mainWin;
        private ProductWindow _prodWin;
        private RepositoryHolder _repoHolder;
        private ProductListPage _prodList;

        /// <summary>
        /// Propercja przyjmująca nową nazwę dla edytowanego produktu
        /// </summary>
        public string NewName { get; set; }

        /// <summary>
        /// Propercja przyjmująca nową ilość produktu w magazynie dla edytowanego produktu
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Propercja przyjmująca nową cenę dla edytowanego produktu
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Propercja przechowywująca zaznaczony produkt
        /// </summary>
        public EFProduct SelectedProduct { get; set; }

        public EditProductPage(MainWindow mainWin, ProductWindow prodWin, RepositoryHolder repoHolder, ProductListPage prodList, EFProduct selectedProduct)
        {
            _mainWin = mainWin;
            _repoHolder = repoHolder;
            _prodWin = prodWin;
            _prodList = prodList;
            SelectedProduct = selectedProduct;
            DataContext = this;
            InitializeComponent();
        }

        private void Zapisz_Button_Click(object sender, RoutedEventArgs e)
        {
            SelectedProduct.Name = NewName;
            SelectedProduct.Quantity = Quantity;
            SelectedProduct.Price = Price;
            _repoHolder.ProdRepo.Save();
            _prodWin.Close();
            _prodList.ProductList_ListBox.Items.Refresh();
        }

        private void Anuluj_Button_Click(object sender, RoutedEventArgs e)
        {
            _prodWin.Close();
        }
    }
}
