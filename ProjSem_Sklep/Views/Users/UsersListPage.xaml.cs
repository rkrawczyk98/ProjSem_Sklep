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

namespace ProjSem_Sklep.Views.Users
{
    /// <summary>
    /// Interaction logic for UsersListPage.xaml
    /// </summary>
    public partial class UsersListPage : Page
    {
        private MainWindow _mainWindow;
        private RepositoryHolder _repoHolder;

        public List<User> UserList { get; set; }

        public User SelectedUser { get; set; }

        public UsersListPage(MainWindow mainWin, RepositoryHolder repoHolder)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            DataContext = this;
            UserList = (List<User>)_repoHolder.UserRepo.GetAll();
            InitializeComponent();
        }

        private void Usun_Button_Click(object sender, RoutedEventArgs e)
        {
            _repoHolder.UserRepo.Remove(SelectedUser);
            _repoHolder.UserRepo.Save();
        }

        private void UserList_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listbox = (ListBox)sender;
            var item = (User)listbox.SelectedItem;
            SelectedUser = item;
        }
    }
}
