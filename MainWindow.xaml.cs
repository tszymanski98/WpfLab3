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
using Microsoft.Win32;
using System.IO;

namespace WpfLab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Article> ity = new List<Article>();
        public MainWindow()
        {
            InitializeComponent();
            datagrid1.ItemsSource = ity;
            ///           Testowe artykuły:
            ///           datagrid1.Items.Add(new Article("Cola", 1, 4));
            ///           datagrid1.Items.Add(new Article("Fanta", 2, 90));
        }

        public class Article
        {
            public string NameDat { get; set; }

            public string IDDat { get; set; }

            public int CountDat { get; set; }

            /*
            public Article(string Name, int ID, int Count)
            {
                NameDat = Name;
                IDDat = ID;
                CountDat = Count;
            }
            */
        }

        public void DodArt(string artykul, string ilosc)
        {
            int index = ity.Count + 1;
            ity.Add(new Article()
            {NameDat = artykul,IDDat = index.ToString(),CountDat = int.Parse(ilosc)});
            datagrid1.Items.Refresh();
        }

        private void zapis_but(object sender, RoutedEventArgs e)
        {
            string saveText = "";
            foreach(Article art in ity)
            {
                saveText += $"{art.NameDat},{art.IDDat},{art.CountDat}\n";
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog()==true)
            {
                File.WriteAllText(saveFileDialog.FileName, saveText);
            }
        }
        private void odczyt_but(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog()==true)
            {
                ity.Clear();
                foreach(string line in File.ReadLines(openFileDialog.FileName))
                {
                    string[] args = line.Split(',');
                    DodArt(args[0], args[2]);
                }
            }
        }

        private void dod_but(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.ShowDialog();
        }
    }
}
