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
using Childrens_sanatorium.Pages.Admin;
using Childrens_sanatorium.Pages;

namespace Childrens_sanatorium.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для Admin_main_page.xaml
    /// </summary>
    public partial class Admin_main_page : Page
    {
        public Admin_main_page()
        {
            InitializeComponent();
        }

        private void admin_page_Selected(object sender, RoutedEventArgs e)
        {
            Menu.Navigate(new Admin_page());
        }

        private void users_Selected(object sender, RoutedEventArgs e)
        {
            Menu.Navigate(new Users ());
        }

        private void Exit_Selected(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authorization ());
        }

        private void emploee_Selected(object sender, RoutedEventArgs e)
        {
            Menu.Navigate(new staff_page());
        }
    }
}
