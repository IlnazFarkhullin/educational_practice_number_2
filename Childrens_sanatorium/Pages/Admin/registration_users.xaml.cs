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
using System.Windows.Shapes;
using Childrens_sanatorium.Db;

namespace Childrens_sanatorium.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для registration_users.xaml
    /// </summary>
    public partial class registration_users : Window
    {
        
        public registration_users()
        {
            InitializeComponent();
            new_user.ItemsSource = connect.childrens_Sanatorium.Employee.ToList().Where(z => z.id_position == 2).Where(z => z.id_user == null );
        }

        private void new_user_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var user = ((sender as ListView).SelectedItem as Employee);
            reguswindow us = new reguswindow(user);
            us.Show();
            Close();
        }
    }
}
