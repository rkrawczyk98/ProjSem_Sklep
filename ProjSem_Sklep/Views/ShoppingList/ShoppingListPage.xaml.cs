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

namespace ProjSem_Sklep.Views.ShoppingList
{
    /// <summary>
    /// Interaction logic for ShoppingListPage.xaml
    /// </summary>
    public partial class ShoppingListPage : Page
    {
        private MainWindow _mainWindow;
        private RepositoryHolder _repoHolder;

        public ShoppingListPage(MainWindow mainWin, RepositoryHolder repoHolder)
        {
            _repoHolder = repoHolder;
            _mainWindow = mainWin;
            DataContext = this;
            InitializeComponent();
        }
    }
}
