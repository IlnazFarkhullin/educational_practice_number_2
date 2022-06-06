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

namespace Childrens_sanatorium.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для Staff_info.xaml
    /// </summary>
    public partial class Staff_info : Window
    {
        Db.Employee emp = new Db.Employee();
        public Staff_info(Db.Employee s)
        {
            InitializeComponent();
            emp = s;
            this.DataContext = emp;
            
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog print = new PrintDialog();
            if (print.ShowDialog() == true)
            {
                print.PrintVisual(staff_info, "Печать");
            }
        }
    }
}
