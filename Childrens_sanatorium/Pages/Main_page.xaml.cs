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
using Childrens_sanatorium.Pages;
using Childrens_sanatorium.Db;

namespace Childrens_sanatorium.Pages
{
    /// <summary>
    /// Логика взаимодействия для Main_page.xaml
    /// </summary>
    public partial class Main_page : Page
    {
        public Main_page()
        {
            InitializeComponent();

            if (MainWindow.user.id_user != 2)
            {
                regestration.Visibility = Visibility.Collapsed;
            }
        }
       
        private void my_page_Selected(object sender, RoutedEventArgs e)
        {
            
            Menu.NavigationService.Navigate(new My_page());
        }

        private void Children_Selected(object sender, RoutedEventArgs e)
        {
            Menu.NavigationService.Navigate(new Ward_number_one());
        }

        private void Exit_Selected(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Authorization());
        }

        private void ward_two_Selected(object sender, RoutedEventArgs e)
        {
            Menu.Navigate(new War_number_two());
        }

        private void regestration_Selected(object sender, RoutedEventArgs e)
        {
            Menu.Navigate(new add_children());
        }
    }
}
