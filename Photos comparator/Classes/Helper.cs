using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Photos_comparator.Classes
{
    public class Helper
    {
        private static PhotosComparatorEntities connection = new PhotosComparatorEntities();
        public static PhotosComparatorEntities Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        private static Author currentAuthor = new Author();
        public static Author CurrentAuthor
        {
            get { return currentAuthor; }
            set { currentAuthor = value; }
        }

        public static void GoNextWindow(Window nextWindow, Window oldWindow)
        {
            nextWindow.Show();
            oldWindow.Close();
        }
    }
}
