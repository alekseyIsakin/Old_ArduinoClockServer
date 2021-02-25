using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ArdClock.window
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class OutLibreEdit : Window
    {
        Dictionary<string, string> PathToDll = new Dictionary<string, string>();

        public OutLibreEdit()
        {
            InitializeComponent();
            CheckOutLibre();
        }


        private void CheckOutLibre()
        {
            string[] allfiles = System.IO.Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            PathToDll = new Dictionary<string, string>();
            foreach (var f in allfiles)
            {
                if (f.Split('.')[1] == "dll") 
                {
                    string name = System.IO.Path.GetFileName(f);
                    PathToDll.Add(name, f);
                }
            }
            ListPathToDll.ItemsSource = PathToDll.Keys;
        }

        private void ButtonUpdate_Click(object sender, RoutedEventArgs e)
        {
            CheckOutLibre();
        }
    }
}
