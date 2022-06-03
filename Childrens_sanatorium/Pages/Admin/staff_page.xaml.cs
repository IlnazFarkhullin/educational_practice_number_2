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

using Microsoft.Win32;


namespace Childrens_sanatorium.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для staff_page.xaml
    /// </summary>
 
    public partial class staff_page : Page
    {
        
        public staff_page()
        {
            InitializeComponent();
            LV_staff.ItemsSource = connect.childrens_Sanatorium.Employee.ToList();
            filter.ItemsSource = connect.childrens_Sanatorium.Position.ToList();
            var a = Db.connect.childrens_Sanatorium.Employee.Where(z => z.id_employee == z.id_employee).Count();
            count.Text = a.ToString();
          
           
        }

        private void LV_staff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var s = ((sender as ListView).SelectedItem as Db.Employee);
            Staff_info _Info = new Staff_info(s);
            _Info.Show();
        }

        private void add_user_Click(object sender, RoutedEventArgs e)
        {
            registration_staff st = new registration_staff();
            st.Show();
        }
        private void filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           var b = filter.SelectedItem as Db.Position;
           LV_staff.ItemsSource = Db.connect.childrens_Sanatorium.Employee.Where(z => z.id_position == b.id_position).ToList();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var b = LV_staff.SelectedItem as Employee;
            if (b != null)
            {
                connect.childrens_Sanatorium.Employee.Remove(b);
                connect.childrens_Sanatorium.SaveChanges();
                LV_staff.ItemsSource = connect.childrens_Sanatorium.Employee.ToList();
                MessageBox.Show($"Сотрудник {b.Surname} {b.Name} {b.Patronymic} больше не работает в данной больнице", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Для начала выберите запись!!!");
            }
        }
        public void Refresh()
        {
            LV_staff.ItemsSource = connect.childrens_Sanatorium.Employee.ToList();
            var a = Db.connect.childrens_Sanatorium.Employee.Where(z => z.id_employee == z.id_employee).Count();
            count.Text = a.ToString();
           
        }
        private void count_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int i))
            {
                e.Handled = true;
            }

            if (e.Text == e.Text.ToLower())
            {
                e.Handled = true;
            }
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

       
    }
}
