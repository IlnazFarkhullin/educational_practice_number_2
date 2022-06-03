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

namespace Childrens_sanatorium.Pages
{
    /// <summary>
    /// Логика взаимодействия для patient_info.xaml
    /// </summary>
    public partial class patient_info : Window
    {
        Db.Children post_children;
        public patient_info(Db.Children patient)
        {
            InitializeComponent();
            post_children = patient;
            this.DataContext = post_children;
        }

        private void print_Click(object sender, RoutedEventArgs e) // позволяет печатать информацию
        {
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == true)
            {
                print.PrintVisual(info, "Печать");
            }

        }

        private void Edit_Click(object sender, RoutedEventArgs e) // редактирование
        {
            var a = Db.connect.childrens_Sanatorium.Children.Where(z => z.id_children == post_children.id_children).FirstOrDefault();
            a.Comments = comment.Text;
            Db.connect.childrens_Sanatorium.SaveChanges();
            MessageBox.Show("Изменения сохранены");
;        }
    }
}
