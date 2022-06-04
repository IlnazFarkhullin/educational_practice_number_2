using System;
using System.Collections.Generic;
using System.IO;
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
using Microsoft.Win32;

namespace Childrens_sanatorium.Pages.Admin
{
   
    public partial class reguswindow : Window
    {
        Db.Employee newus;
        Db.user newuser = new user();
        public reguswindow(Employee us)
        {
            InitializeComponent();
            newus = us;
            this.DataContext = newus;
            
        }

        private void generator_Click(object sender, RoutedEventArgs e)
        {
            genPass();
            genLogin();
        }
        public void genPass()
        {
            string pass = "";
            string[] array = {
                "0","1","2","3","4","5","6","7","8","9",
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
            };
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                pass = pass + array[rnd.Next(0, 35)];
            }
            txt_password.Text = pass.ToString();
        }

        public  void genLogin()
        {
            string log = "";
            string[] array = {
                "0","1","2","3","4","5","6","7","8","9",
                "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
            };
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                log =  array[rnd.Next(0, 35)]+log ;
            }
            txt_login.Text = log.ToString();
        }

        private void usreg_Click(object sender, RoutedEventArgs e)
        {
            if (txt_password.Text != null && txt_login.Text != null)
            {
                var a = connect.childrens_Sanatorium.user;  //Where(z => z. == txt_surname.Text )
                if (a != null)
                {
                   
                    Db.user usera = new user()
                    {

                        
                        login = txt_login.Text,
                        password = txt_password.Text
                    
                    
                    };
                    Db.connect.childrens_Sanatorium.user.Add(usera);
                    var r = connect.childrens_Sanatorium.Employee.Where( z => z.id_user == z.id_user);
                    Db.connect.childrens_Sanatorium.SaveChanges();
                    MessageBox.Show($"Новый пользователь {newus.Surname} добавлен.", "Регистрация пациента", MessageBoxButton.OK, MessageBoxImage.Information);
            
                }
                else
                {
                    MessageBox.Show("Такой пользователь уже зарегистрирован", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Заполните поля ЛОГИН и ПАРОЛЬ!!!!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
           
        }

        private void addImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                newus.image = File.ReadAllBytes(openFileDialog.FileName);
                MemoryStream byteStream = new MemoryStream(newus.image);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                IPicture.Source = image;
            }
        }
    }
    }


