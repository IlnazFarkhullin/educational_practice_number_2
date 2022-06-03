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
using Childrens_sanatorium.Pages.Admin;
using Childrens_sanatorium.Db;

namespace Childrens_sanatorium.Pages
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Page
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_login.Text) || string.IsNullOrEmpty(txt_password.Password))
            {
                MessageBox.Show($"Пожалуйста введите логин и пароль", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                var a = connect.childrens_Sanatorium.user.Where(z => z.login == txt_login.Text && z.password == txt_password.Password).FirstOrDefault();
                
                if (a != null)
                {

                    //var d = connect.childrens_Sanatorium.Employee.ToList();
                    var d = a.Employee.FirstOrDefault();
                    if (a.id_user == 1)
                    {
                        MessageBox.Show($"Добро пожаловать  {d.Name} {d.Patronymic}", "Вход в личные кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow.user = d; //показывает того кто авторизовался. На той странице используется this.DataContext..........
                        NavigationService.Navigate(new Admin_main_page());
                    }
                    else if(a.id_user == a.id_user)
                    {
                        MessageBox.Show($"Добро пожаловать  {d.Name} {d.Patronymic}", "Вход в личные кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                        MainWindow.user = d;

                        NavigationService.Navigate(new Main_page());
                    }
                }
                else
                {
                    MessageBox.Show($"Логин или пароль не верный!\n Пожалуйста попробуйте ещё раз", "Вход в личный кабинет", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }
    }
}
