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
using Photos_comparator.UserControlls;

namespace Photos_comparator.Windows.User
{
    /// <summary>
    /// Логика взаимодействия для ShowSimilarPhotoWindow.xaml
    /// </summary>
    public partial class ShowSimilarPhotoWindow : Window
    {
        public List<string> SimilarImagePathList { get; set; }
        public ShowSimilarPhotoWindow(List<string> similarImagePathList, bool isDatabaseSearch)
        {
            SimilarImagePathList = similarImagePathList;
            InitializeComponent();
            foreach (string path in SimilarImagePathList)
            {
                if (isDatabaseSearch)
                {
                    InformationAboutImage block = new InformationAboutImage(path);
                    WrapPanelForImages.Children.Add(block);
                }
                else
                {
                    Image img = new Image();
                    img.Source = new BitmapImage(new Uri(path));
                    img.Width = 150;
                    img.Width = 150;
                    img.Stretch = Stretch.Fill;
                    WrapPanelForImages.Children.Add(img);
                }
            }
        }

        private void ShowAllPathsButton_Click(object sender, RoutedEventArgs e)
        {
            string resultMessage = "";
            foreach (string path in SimilarImagePathList)
            {
                resultMessage += path + "\n";
            }
            MessageBox.Show(resultMessage);
        }

        private void GoBackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow nextWindow = new MainWindow();
            nextWindow.Show();
            this.Close();
        }
    }
}
