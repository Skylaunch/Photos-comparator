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

namespace Photos_comparator.Windows.User
{
    /// <summary>
    /// Логика взаимодействия для SliderWidow.xaml
    /// </summary>
    public partial class ProgressBarWindow : Window
    {
        public int MaxValue { get; set; }
        public ProgressBarWindow(int max)
        {
            MaxValue = max;
            InitializeComponent();
            DataContext = this;
        }
    }
}
