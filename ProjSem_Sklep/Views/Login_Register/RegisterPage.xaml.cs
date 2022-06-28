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

namespace ProjSem_Sklep.Views.Login_Register
{
    /// <summary>
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        private MainWindow _mainWindow;
        private RepositoryHolder _repoHolder;

        /// <summary>
        /// Propercja przypisująca nazwę użytkownika na potrzeby rejestracji nowego konta
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Propercja przypisująca hasło na potrzeby rejestracji nowego konta
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Properjca służąca do sprawdzenia czy użytkownik nie popełnił literówki przy wpisywaniu hasła podczas tworzenia nowego konta
        /// </summary>
        public string RepeatPassword { get; set; }

        /// <summary>
        /// Propercja określająca czy dany użytkownik jest administratorem
        /// </summary>
        public bool IsAdmin { get; set; }

        public RegisterPage(MainWindow mainWin, RepositoryHolder repoHolder)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            DataContext = this;
            InitializeComponent();
        }

        private void Anuluj_Button_Click(object sender, RoutedEventArgs e)
        {
            DataContext = _mainWindow;
            _mainWindow.Content = new LoginPage(_repoHolder, _mainWindow);

        }

        private void UtworzKonto_Button_Click(object sender, RoutedEventArgs e)
        {
            var account = _repoHolder.UserRepo.FindUser(Login);
            if (Password != RepeatPassword)
                MessageBox.Show("Hasla nie sa takie same!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            else if (account == null)
            {
                _repoHolder.UserRepo.Add(new User() { Login = this.Login, Password = this.Password, IsAdmin = this.IsAdmin });
                _repoHolder.UserRepo.Save();
            }
            else if(account.Login == Login)
                MessageBox.Show("Konto o takiej nazwie juz istnieje!", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            
        }
    }
}
