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
using Childrens_sanatorium.Db;

namespace Childrens_sanatorium.Pages
{
    /// <summary>
    /// Логика взаимодействия для My_page.xaml
    /// </summary>
    public partial class My_page : Page
    {
      
        public My_page()
        {
            InitializeComponent();
            this.DataContext = MainWindow.user;
            this.DataContext = MainWindow.emp;

        }
    }
}
