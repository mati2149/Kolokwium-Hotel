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

namespace Kolokwium
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Hotel hotel = new Hotel();
        public MainWindow()
        {
            InitializeComponent();

            Glowny.Visibility = Visibility.Hidden;
            GridGoscia.Visibility = Visibility.Hidden;
            GridDaty.Visibility = Visibility.Hidden;
        }

        private void DataRezerwacji_Click(object sender, RoutedEventArgs e)
        {
            GridDaty.Visibility = Visibility.Visible;
            GridGoscia.Visibility = Visibility.Hidden;
        }

        private void DodajRezerwacje_Click(object sender, RoutedEventArgs e)
        {
            GridDaty.Visibility = Visibility.Hidden;
            GridGoscia.Visibility = Visibility.Visible;
            Glowny.Visibility = Visibility.Visible;
            Wstep.Visibility = Visibility.Hidden;
        }

        private void UsunRezerwacje_Click(object sender, RoutedEventArgs e)
        {
            hotel.OdwołajRezerwacje();
            Glowny.Text = hotel.ToString();
        }

        private void Wyczysc_Click(object sender, RoutedEventArgs e)
        {
            Glowny.Clear();
        }

        private void DataDodaj_Click(object sender, RoutedEventArgs e)
        {
            DateTime data = DateTime.Parse(Data.Text);
            hotel.UstawDate(data);
        }

        private void GoscDodaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string imie = Imie.Text;
                string nazwisko = Nazwisko.Text;
                int pokoj = int.Parse(NrPokoju.Text);
                int cena = int.Parse(Cena.Text);

                if (cena <= 0) throw new ArgumentOutOfRangeException();
                if (pokoj <= 0) throw new ArgumentOutOfRangeException();

                hotel.DodajRezerwacje(imie, nazwisko, pokoj, cena);
                Glowny.Text = hotel.ToString();
            }
            catch
            {
                MessageBox.Show("Podano bledne dane");
            }
        }



    }
}
