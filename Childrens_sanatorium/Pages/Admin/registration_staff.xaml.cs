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
    public partial class registration_staff : Window
    {
        Db.Employee staff = new Db.Employee();
        public registration_staff()
        {
            InitializeComponent();
            position.ItemsSource = connect.childrens_Sanatorium.Position.ToList();

        }

        private void add_image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                staff.image = File.ReadAllBytes(openFileDialog.FileName);
                MemoryStream byteStream = new MemoryStream(staff.image);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                Image.Source = image;
            }
        }

        private void adddd_Click(object sender, RoutedEventArgs e)
        {
            if (txt_name.Text.Length <= 20 && txt_sname.Text.Length <= 15 && txt_lastname.Text.Length <=15 )
            {

            if (txt_sname.Text !=null && txt_name.Text != null && birthday.SelectedDate != null && position.SelectedItem !=null)
            {
                var a = connect.childrens_Sanatorium.Employee.Where(z => z.Surname == txt_sname.Text).FirstOrDefault();
                if (a == null)
                {
                    var b = position.SelectedItem as Db.Branches;
                    staff.Surname = txt_sname.Text;
                    staff.Name = txt_name.Text;
                    staff.Patronymic = txt_lastname.Text;
                    staff.Birthday = DateTime.Now;
                    staff.id_position = ((Db.Position)position.SelectedItem).id_position;
                    Db.connect.childrens_Sanatorium.Employee.Add(staff);
                    Db.connect.childrens_Sanatorium.SaveChanges();
                    MessageBox.Show($"Новый сотрудник добавлен {staff.Surname} {staff.Name} {staff.Patronymic} добавлен.\n Занимаемая должность {staff.id_position}", "Регистрация пациента", MessageBoxButton.OK, MessageBoxImage.Information);
                    clear();
                    Close();
                    
                    
                }
                else
                {
                    MessageBox.Show("Такой сотрудник уже зарегистрирован", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                MessageBox.Show("Зполните поля");
            }
            }
            else
            {
                MessageBox.Show("Вы нарушили символьное ограничение.\n Сократите количество символов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public void clear()
        {
            txt_name.Clear();
            txt_sname.Clear();
            txt_lastname.Clear();
            birthday.Text = "";
            Image.Source = null;
        }

        private void txt_sname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int i))
            {
                e.Handled = true;
            }
        }

        private void txt_name_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int i))
            {
                e.Handled = true;
            }
        }

        private void txt_lastname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int i))
            {
                e.Handled = true;
            }
        }

        private void birthday_PreviewDragEnter(object sender, DragEventArgs e)
        {
            if (!Char.IsDigit(e.ToString(), 0))
            {
                e.Handled = true;
            }
        }
    }
}
