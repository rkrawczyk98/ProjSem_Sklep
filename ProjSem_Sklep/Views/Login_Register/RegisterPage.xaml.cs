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

        public string Login { get; set; }

        public string Password { get; set; }

        public string RepeatPassword { get; set; }

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
            _mainWindow = _mainWindow;

        }

        private void UtworzKonto_Button_Click(object sender, RoutedEventArgs e)
        {
            _repoHolder.UserRepo.Add(new User() { Login = this.Login, Password = this.Password, IsAdmin = this.IsAdmin });
            _repoHolder.UserRepo.Save();
        }
    }
}
