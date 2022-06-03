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
    /// Логика взаимодействия для Ward_number_one.xaml
    /// </summary>
    public partial class Ward_number_one : Page
    {
        public Ward_number_one()
        {
            InitializeComponent();
            children.ItemsSource = connect.childrens_Sanatorium.Children.ToList().Where(z => z.id_ward == 1);
            filter.ItemsSource = connect.childrens_Sanatorium.Employee.ToList().Where(s => s.id_position == 2);
            var a = Db.connect.childrens_Sanatorium.Children.Where(z => z.id_children == z.id_children).Where(s => s.id_ward == 1).Count();
            count.Text = a.ToString();
        }

        private void children_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var patient = ((sender as ListView).SelectedItem as Db.Children);
            patient_info a = new patient_info(patient);
            a.Show();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            var b = children.SelectedItem as Children;
            if (b != null)
            {
                connect.childrens_Sanatorium.Children.Remove(b);
                connect.childrens_Sanatorium.SaveChanges();
                children.ItemsSource = connect.childrens_Sanatorium.Children.ToList();
                MessageBox.Show($"Пациент {b.Surname} {b.Name} {b.Patronymic} Больше не числится в данной больнице", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            else
            {
                MessageBox.Show("Для начала выберите запись!!!");
            }
        }

        private void sort_az_Click(object sender, RoutedEventArgs e)
        {
            children.ItemsSource = connect.childrens_Sanatorium.Children.ToList().Where(s => s.id_ward == 1).OrderBy(z => z.Surname);
        }

        private void serach_tb_TextChanged(object sender, TextChangedEventArgs e)
        {
            children.ItemsSource = connect.childrens_Sanatorium.Children.Where(z => z.Surname.ToLower().Contains(serach_tb.Text)).Where(s => s.id_ward == 1).ToList();
        }

        private void filter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var b = filter.SelectedItem as Db.Employee;
            children.ItemsSource = Db.connect.childrens_Sanatorium.Children.Where(z => z.id_emploee == b.id_employee).Where(s => s.id_ward == 2).ToList();
        }
    }
}
