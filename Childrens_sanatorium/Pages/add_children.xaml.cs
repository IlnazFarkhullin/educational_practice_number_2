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
using Microsoft.Win32;
using System.IO;
using Childrens_sanatorium.Db;


namespace Childrens_sanatorium.Pages
{
    /// <summary>
    /// Логика взаимодействия для add_children.xaml
    /// </summary>
    public partial class add_children : Page
    {
        Db.Children patient = new Db.Children();
        public add_children()
        {
            InitializeComponent();
            branches.ItemsSource = connect.childrens_Sanatorium.Branches.ToList();
            ward.ItemsSource = connect.childrens_Sanatorium.Ward.ToList();
            diagnosis.ItemsSource = connect.childrens_Sanatorium.Diagnosis.ToList();
            emploee.ItemsSource = connect.childrens_Sanatorium.Employee.ToList().Where(z => z.id_position == 2);
            receipt.DisplayDateStart = DateTime.Now;//запрет на выбор заднего числа
        }

        private void adddd_Click(object sender, RoutedEventArgs e)//метод для добавления информации
        {
            if (txt_name.Text.Length <= 10 && txt_sname.Text.Length <=20 && txt_lastname.Text.Length <= 15 )
            {
               if (txt_name.Text !=null && txt_sname.Text !=null && diagnosis.SelectedItem !=null && branches !=null && emploee != null && birthday.SelectedDate != null && receipt.SelectedDate != null && branches.SelectedItem != null && ward.SelectedItem != null && emploee.SelectedItem != null)
                { 
                var a = connect.childrens_Sanatorium.Children.Where(z => z.Surname == txt_sname.Text).FirstOrDefault();
                    if (a == null)
                    {

                        var b = branches.SelectedItem as Db.Branches;
                        var c = ward.SelectedItem as Db.Ward;
                        var d = diagnosis.SelectedItem as Db.Diagnosis;
                        patient.Surname = txt_sname.Text;
                        patient.Name = txt_name.Text;
                        patient.Patronymic = txt_lastname.Text;
                        patient.Birthday = DateTime.Now;
                        patient.Date_of_receipt = DateTime.Now;
                        patient.id_diagnosis = ((Diagnosis)diagnosis.SelectedItem).id_diagnosis;
                        patient.id_braches = ((Db.Branches)branches.SelectedItem).id_branches;
                        patient.id_ward = ((Db.Ward)ward.SelectedItem).id_ward;
                        patient.id_emploee = ((Db.Employee)emploee.SelectedItem).id_employee;
                        Db.connect.childrens_Sanatorium.Children.Add(patient);
                        Db.connect.childrens_Sanatorium.SaveChanges();
                        MessageBox.Show($"Пациент {patient.Surname} добавлен. Пациент находится в палате ", "Регистрация пациента", MessageBoxButton.OK, MessageBoxImage.Information);
                        clear();
                    }
                else
                {
                    MessageBox.Show("Такой пациент уже зарегистрирован", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
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
            diagnosis.Text = "";
            receipt.Text = "";
            branches.Text = "";
            ward.Text = "";
            emploee.Text = "";
            Image.Source = null;
        }

        private void add_image_Click(object sender, RoutedEventArgs e)//метод для добавления фотографии
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                patient.Image = File.ReadAllBytes(openFileDialog.FileName);
                MemoryStream byteStream = new MemoryStream(patient.Image);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                Image.Source = image;
            }
        }

        private void birthday_PreviewDragEnter(object sender, DragEventArgs e)// запрет на введение букв
        {
            if (!Char.IsDigit(e.ToString(), 0))
            {
                e.Handled = true;
            }
        }

        private void receipt_PreviewDragEnter(object sender, DragEventArgs e)//запрет на введение букв
        {

            if (!Char.IsDigit(e.ToString(), 0))
            {
                e.Handled = true;
            }
        }

        private void txt_sname_PreviewTextInput(object sender, TextCompositionEventArgs e)// запрет на введение цифр
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

        private void diagnosis_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int i))
            {
                e.Handled = true;
            }
        }

        //private void branches_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var x = branches.SelectedItem as Db.Branches;
        //    if (x.id_branches == 1)
        //    {
        //        ward.ItemsSource = connect.childrens_Sanatorium.Ward.Where(z => z.id_ward == 1).ToList();
        //    }
        //    else  
        //    {
        //        ward.ItemsSource = connect.childrens_Sanatorium.Ward.Where(z => z.id_ward == 2).ToList();
        //    }
        //}
    }
}
