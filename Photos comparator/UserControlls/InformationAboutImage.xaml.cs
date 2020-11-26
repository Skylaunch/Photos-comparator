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

using Photos_comparator.Classes;
namespace Photos_comparator.UserControlls
{
    /// <summary>
    /// Логика взаимодействия для InformationAboutImage.xaml
    /// </summary>
    public partial class InformationAboutImage : UserControl
    {

        public List<Photo> PhotoList { get; set; } 

        public InformationAboutImage(string path)
        {
            PhotoList = Helper.Connection.Photo.ToList();
            InitializeComponent();
            DataContext = null;
            foreach(Photo p in PhotoList)
            {
                if(p.Path == path)
                {
                    DataContext = p;
                    break;
                }
            }
            if(DataContext == null)
            {
                AuthorLabel.Visibility = Visibility.Hidden;
                CategoryLabel.Visibility = Visibility.Hidden;
                MyImage.Source = new BitmapImage(new Uri(path));
            }
        }
    }
}
