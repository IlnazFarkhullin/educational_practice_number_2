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
using Childrens_sanatorium.Pages.Admin;

namespace Childrens_sanatorium.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для Users.xaml
    /// </summary>
    public partial class Users : Page
    {
        public Users()
        {
            InitializeComponent();
            LV_users.ItemsSource = connect.childrens_Sanatorium.user.ToList();
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
           LV_users.ItemsSource = connect.childrens_Sanatorium.Employee.ToList().Where(z => z.Surname.Contains(serach_tb.Text));//поиск о фамилии
        }

        private void add_user_Click(object sender, RoutedEventArgs e)
        {
            registration_users user = new registration_users();
            user.Show();
       }

        
        private void LV_users_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var us = ((sender as ListView).SelectedItem as Employee);
            Users_information _Info = new Users_information(us);// передача данных на другую форму
            _Info.Show();// открытие окна при нажатии на элемент ListView   
        }

        private void refrsh_Click(object sender, RoutedEventArgs e)
        {
            LV_users.ItemsSource = connect.childrens_Sanatorium.user.ToList();
        }
    }
}
