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

namespace WpfLab3
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        public string Art = "";
        public string Ilo = "";

        private void dodaj_but(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).DodArt(Art, Ilo);
        }

        private void Art_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            TextBox tb = e.Source as TextBox;
            Art = tb.Text;
        }
        private void Ilo_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            TextBox tb = e.Source as TextBox;
            Ilo = tb.Text;
        }
    }
}
