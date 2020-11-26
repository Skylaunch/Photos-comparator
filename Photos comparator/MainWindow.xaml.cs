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

using XnaFan.ImageComparison;
using System.Drawing;
using Image = System.Drawing.Image;

using Photos_comparator.Classes;
using Photos_comparator.Windows;


namespace Photos_comparator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AuthorButton_Click(object sender, RoutedEventArgs e)
        {
            Helper.GoNextWindow(new AuthorAuthorizationWindow(), this);
        }

        private void SearchDBButton_Click(object sender, RoutedEventArgs e)
        {
            Helper.GoNextWindow(new Windows.User.SearchInDatabaseWindow(), this);
        }

        private void SearchFolderButton_Click(object sender, RoutedEventArgs e)
        {
            Helper.GoNextWindow(new Windows.User.SearchInFolderWindow(), this);

        }
    }
}
