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
    public partial class Users_information : Window
    {
        Employee post_user;
        
        public Users_information(Employee us)
        {
            InitializeComponent();
            post_user = us;
            this.DataContext = post_user;
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(info, "Печать");
            }
        }

        private void add_image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                post_user.image = File.ReadAllBytes(openFileDialog.FileName);
                MemoryStream byteStream = new MemoryStream(post_user.image);
                BitmapImage image = new BitmapImage();
                image.BeginInit();
                image.StreamSource = byteStream;
                image.EndInit();
                IPicture.Source = image;
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var a = Db.connect.childrens_Sanatorium.Employee.Where(z => z.id_user == post_user.id_user).FirstOrDefault();
            MemoryStream memory = new MemoryStream(post_user.image);
            BitmapImage img = new BitmapImage();
            img.BeginInit();
            img.StreamSource = memory;
            img.EndInit();
            IPicture.Source = img;
            Db.connect.childrens_Sanatorium.SaveChanges();
            MessageBox.Show("Изменения сохранены");
        }
    }
}
