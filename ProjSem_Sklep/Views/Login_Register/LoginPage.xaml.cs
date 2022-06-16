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

namespace ProjSem_Sklep.Views.Login_Register
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private MainWindow _mainWindow;
        private RepositoryHolder _repoHolder;
        public RepositoryHolder RepoHolder => _repoHolder;

        public LoginPage(RepositoryHolder repoHolder, MainWindow mainWin)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            InitializeComponent();
        }

        private void Zaloguj_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UtworzKonto_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
