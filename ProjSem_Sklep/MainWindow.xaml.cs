using Microsoft.EntityFrameworkCore;
using ProjSem_Sklep.Views.Login_Register;
using ProjSem_Sklep_Lib.Context;
using ProjSem_Sklep_Lib.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjSem_Sklep
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RepositoryHolder _repoHolder;
        private DbContext _dbContext;

        public MainWindow()
        {
            _dbContext = new ProjSemDbContext();
            _repoHolder = new RepositoryHolder(new OrderRepository(_dbContext),
                                               new ProductRepository(_dbContext),
                                               new UserRepository(_dbContext),
                                               new ProdOrdRepository(_dbContext));
            InitializeComponent();
            this.Content = new LoginPage(_repoHolder, this);
        }
    }
}
