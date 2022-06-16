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

namespace ProjSem_Sklep.Views.Home
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private MainWindow _mainWindow;
        private RepositoryHolder _repoHolder;

        public HomePage(MainWindow mainWin, RepositoryHolder repoHolder)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            DataContext = this;
            InitializeComponent();
        }

        private void Koszyk_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Produkty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Zamowienia_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Uzytkownicy_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
