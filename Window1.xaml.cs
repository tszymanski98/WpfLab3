using System.Windows;
using System.Windows.Controls;

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
