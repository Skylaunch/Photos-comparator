using Microsoft.Win32;
using Photos_comparator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using XnaFan.ImageComparison;

namespace Photos_comparator.Windows.User
{
    /// <summary>
    /// Логика взаимодействия для SearchInDatabaseWindow.xaml
    /// </summary>
    public partial class SearchInDatabaseWindow : Window
    {
        public static string FullFileName { get; set; } = "";
        public List<Category> CategoryList { get; set; }
        public List<Photo> PhotoList { get; set; }
        public List<Photo> SimilarPhotoList { get; set; } = new List<Photo>();

        public SearchInDatabaseWindow()
        {
            InitializeComponent();
            CategoryList = Helper.Connection.Category.ToList();
            PhotoList = Helper.Connection.Photo.ToList();
            List<string> categoryTitleList = CategoryList.Select(c => c.Title).ToList();
            CategoryComboBox.ItemsSource = categoryTitleList;
        }

        private async void SearchPhotoButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            GoBackButton.IsEnabled = false;
            SearchPhotoButton.IsEnabled = false;
            SelectPhotoButton.IsEnabled = false;
            if (FullFileName == "")
            {
                MessageBox.Show("Пожалуйста, выберите картинку");
                return;
            }
            try
            {
                int counter = 0;
                PhotoList = Helper.Connection.Photo.ToList();
                System.Drawing.Image searchImage = System.Drawing.Image.FromFile(FullFileName);
                PhotoList = PhotoList.Where(p => p.Category.Title == CategoryComboBox.SelectedItem.ToString()).ToList();
                ProgressBarWindow ProgressBarWindow = new ProgressBarWindow(PhotoList.Count);
                ProgressBarWindow.Show();
                await Task.Run(() =>
                {
                    foreach (Photo p in PhotoList)
                    {
                        counter++;
                        Dispatcher.Invoke(() => ProgressBarWindow.ProgressBar.Value = counter); 
                        int counterOfCompare = 0;
                        System.Drawing.Image imageFromDB = System.Drawing.Image.FromFile(p.Path);
                        byte[,] array = ExtensionMethods.GetDifferences(searchImage, imageFromDB);

                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                if (array[i, j] == 0)
                                    counterOfCompare++;
                            }
                        }

                        if (counterOfCompare > 5)
                            SimilarPhotoList.Add(p);
                        continue;
                    }
                    Dispatcher.Invoke(() => ProgressBarWindow.Close());
                    if (SimilarPhotoList.Count > 0)
                    {
                        List<string> similarImagePathList = SimilarPhotoList.Select(p => p.Path).ToList();
                        MessageBox.Show("Совпадение найдено!");
                        Dispatcher.Invoke(() => Helper.GoNextWindow(new ShowSimilarPhotoWindow(similarImagePathList, true), this));
                        return;
                    }
                    else
                    {
                        Dispatcher.Invoke(() =>
                        {
                            string categoryTitle = CategoryComboBox.SelectedItem as string;
                            MessageBox.Show($"К сожалению в категории {categoryTitle} нет схожих изображений");
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GoBackButton.IsEnabled = true;
            SearchPhotoButton.IsEnabled = true;
            SelectPhotoButton.IsEnabled = true;
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
                    ImageTextBox.IsChecked = true;
                }
                else
                    MessageBox.Show("Выбор картинки был отменён");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
