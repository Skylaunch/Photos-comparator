using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
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
using Photos_comparator.Classes;

namespace Photos_comparator.Windows.User
{
    /// <summary>
    /// Логика взаимодействия для SearchInFolderWindow.xaml
    /// </summary>
    public partial class SearchInFolderWindow : Window
    {
        public SearchInFolderWindow()
        {
            InitializeComponent();
        }

        public string FullFileName { get; set; } = "";

        private async void SearchPhotoButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                GoBackButton.IsEnabled = false;
                SearchPhotoButton.IsEnabled = false;
                SelectPhotoButton.IsEnabled = false;
                if (FolderTextBox.Text == "" || FullFileName == "")
                {
                    MessageBox.Show("Введите все данные");
                    return;
                }
                DirectoryInfo directoryInfo = new DirectoryInfo($@"{FolderTextBox.Text}");
                List<string> SimilarImagePathList = new List<string>();
                System.Drawing.Image searchImage = System.Drawing.Image.FromFile(FullFileName);
                ProgressBarWindow progressBarWindow = new ProgressBarWindow(directoryInfo.GetFiles().ToList().Count);
                await Task.Run(() =>
                {
                    int counter = 0;
                    Dispatcher.Invoke(() => progressBarWindow.Show());
                    foreach (var file in directoryInfo.GetFiles())
                    {
                        counter++;
                        Dispatcher.Invoke(() => progressBarWindow.ProgressBar.Value = counter);
                        if (System.IO.Path.GetExtension(file.FullName) == ".jpg" || System.IO.Path.GetExtension(file.FullName) == ".png" || System.IO.Path.GetExtension(file.FullName) == ".jpeg")
                        {
                            int countOfComare = 0;
                            System.Drawing.Image image = System.Drawing.Image.FromFile(file.FullName);
                            byte[,] array = XnaFan.ImageComparison.ExtensionMethods.GetDifferences(searchImage, image);


                            for (int i = 0; i < array.GetLength(0); i++)
                            {
                                for (int j = 0; j < array.GetLength(1); j++)
                                {
                                    if (array[i, j] == 0)
                                        countOfComare++;
                                }
                            }
                            if (countOfComare > 5)
                                SimilarImagePathList.Add(file.FullName);
                        }
                    }
                    Dispatcher.Invoke(() => progressBarWindow.Close());
                    if (SimilarImagePathList.Count > 0)
                    {
                        MessageBox.Show("Совпадения найдены!");
                        Dispatcher.Invoke(() => Helper.GoNextWindow(new User.ShowSimilarPhotoWindow(SimilarImagePathList, false), this));
                        return;
                    }
                    MessageBox.Show("Совпадения в данной папке не найдены");
                });
            }
            catch
            {
                MessageBox.Show("Данный поиск невозможен");
            }
            finally
            {
                GoBackButton.IsEnabled = true;
                SearchPhotoButton.IsEnabled = true;
                SelectPhotoButton.IsEnabled = true;
            }
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
