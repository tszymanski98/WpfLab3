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

namespace WpfLab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ///           Testowe artykuły:
            ///           datagrid1.Items.Add(new Article("Cola", 1, 4));
            ///           datagrid1.Items.Add(new Article("Fanta", 2, 90));
        }

        public class Article
        {
            public string NameDat { get; set; }

            public int IDDat { get; set; }

            public int CountDat { get; set; }

            public Article(string Name, int ID, int Count)
            {
                NameDat = Name;
                IDDat = ID;
                CountDat = Count;

            }
        }

        private void zapis_but(object sender, RoutedEventArgs e)
        {

        }
        private void odczyt_but(object sender, RoutedEventArgs e)
        {

        }

        private void dod_but(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
        }
    }
}
