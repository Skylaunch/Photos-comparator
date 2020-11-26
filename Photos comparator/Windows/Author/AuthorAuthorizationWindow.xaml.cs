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

namespace Photos_comparator.Windows
{
    /// <summary>
    /// Логика взаимодействия для AuthorAuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorAuthorizationWindow : Window
    {
        public List<Author> AuthorList { get; set; }

        public AuthorAuthorizationWindow()
        {
            InitializeComponent();
            AuthorList = Helper.Connection.Author.ToList();
        }

        private void AuthorizationButton_Click(object sender, RoutedEventArgs e)
        {
            foreach (Author a in AuthorList)
            {
                if (LoginTextBox.Text == a.Login && Password.Password == a.Password)
                {
                    Helper.CurrentAuthor = a;
                    Helper.GoNextWindow(new AuthorWindow(), this);
                    return;
                }
            }
            MessageBox.Show("В базе данных нет такого автора!");
        }
    }
}
