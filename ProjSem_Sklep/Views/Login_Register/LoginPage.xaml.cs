using ProjSem_Sklep.Authentication;
using ProjSem_Sklep.Models;
using ProjSem_Sklep.Views.Home;
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

        public string Login { get; set; }

        public string Password { get; set; }

        public static CredentialsHolder CredentialsHolder;

        public static Koszyk Koszyk;

        public LoginPage(RepositoryHolder repoHolder, MainWindow mainWin)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            DataContext = this;
            Koszyk = new Koszyk();
            InitializeComponent();
        }

        private void Zaloguj_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var account = _repoHolder.UserRepo.FindUser(Login, Password);
                if (account == null)
                {
                    MessageBox.Show("Nie znaleziono konta takiego konta", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                var userVM = new UserViewModel() { ID = account.ID, IsAdmin = account.IsAdmin };
                CredentialsHolder = new CredentialsHolder(userVM);
                _mainWindow.Content = new HomePage(_mainWindow, _repoHolder);
            }
            catch (Exception)
            {

                MessageBox.Show("Nie znaleziono konta takiego konta", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }

        private void UtworzKonto_Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Content = new RegisterPage(_mainWindow, _repoHolder);
        }
    }
}
