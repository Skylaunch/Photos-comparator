using Microsoft.Win32;
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
using Photos_comparator.Classes;
using Photos_comparator.Windows;

namespace Photos_comparator.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorWindow.xaml
    /// </summary>
    public partial class AuthorWindow : Window
    {

        public static string FullFileName { get; set; } = "";
        public List<Category> CategoryList { get; set; }
        public List<Photo> PhotoList { get; set; }

        public AuthorWindow()
        {
            InitializeComponent();
            CategoryList = Helper.Connection.Category.ToList();
            PhotoList = Helper.Connection.Photo.ToList();

            List<string> categoryTitleList = CategoryList.Select(c => c.Title).ToList();
            CategoryComboBox.ItemsSource = categoryTitleList;
        }

        private void SelectPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog
                {
                    Filter = "Images (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg"
                };

                if (fileDialog.ShowDialog() == true)
                {
                    FullFileName = fileDialog.FileName;
                    ImageCheckBox.IsChecked = true;
                }
                else
                    MessageBox.Show("Выбор картинки был отменён");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddPhotoButton_Click(object sender, RoutedEventArgs e)
        {
            PhotoList = Helper.Connection.Photo.ToList();
            if (TitleTextBox.Text == "" || FullFileName == "")
            {
                MessageBox.Show("Должны быть заполнены все поля");
                return;
            }
            Photo photo = PhotoList.FirstOrDefault(p => p.Path == FullFileName);
            if(photo != null)
            {
                MessageBox.Show("Добавление данной фотографии невозможно, так как она уже есть в базе");
                return;
            }
            try
            {
                string categoryTitle = CategoryComboBox.SelectedItem as string;

                Photo newPhoto = new Photo()
                {
                    Title = TitleTextBox.Text,
                    Author = Helper.CurrentAuthor,
                    Path = FullFileName,
                    Category = CategoryList.FirstOrDefault(c => c.Title == categoryTitle)
                };

                Helper.Connection.Photo.Add(newPhoto);
                Helper.Connection.SaveChanges();
                MessageBox.Show("Добавление прошло успешно");

                FullFileName = "";
                TitleTextBox.Text = "";
                CategoryComboBox.SelectedIndex = 0;
                ImageCheckBox.IsChecked = false;
            }
            catch
            {
                MessageBox.Show("Ошибка во время добавления картинки в базу данных");
            }
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nextWindow = new MainWindow();
            nextWindow.Show();
            this.Close();
        }
    }
}
