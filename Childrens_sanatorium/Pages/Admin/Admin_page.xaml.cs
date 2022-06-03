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

namespace Childrens_sanatorium.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для Admin_page.xaml
    /// </summary>
    public partial class Admin_page : Page
    {
        public Admin_page()
        {
            InitializeComponent();
            this.DataContext = MainWindow.user;
        }
    }
}
