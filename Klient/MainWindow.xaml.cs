using Klient.ServiceReference1;
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

namespace Klient
{
    /// <summary>
    /// Klasa obslugujaca logike interfejsu okna
    /// Autor: Rafal Wasik
    /// </summary>
    public partial class MainWindow : Window
    {
        DictServiceClient myClient = new DictServiceClient();

        /// <summary>
        /// Konstruktor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda obslugujaca przycisk dodania tlumaczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_add_Click(object sender, RoutedEventArgs e)
        {
            if (myClient.addWord(tb_add_1.Text, tb_add_2.Text))
            {
                tb_wynik.Text = "Dodano!";
            }
            else
                tb_wynik.Text = "Juz istnieje!";
        }

        /// <summary>
        /// Metoda obslugujaca przycisk modyfikacji tlumaczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_mod_Click(object sender, RoutedEventArgs e)
        {
            if (myClient.modifyWord(tb_mod_1.Text, tb_mod_2.Text))
            {
                tb_wynik.Text = "Zmodyfikowano!";
            }
            else
            {
                tb_wynik.Text = "Nie odnaleziono!";
            }

        }

        /// <summary>
        /// Metoda obslugujaca przycisk usuniecia tlumaczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_rem_Click(object sender, RoutedEventArgs e)
        {
            if (myClient.removeWord(tb_rem.Text))
            {
                tb_wynik.Text = "Usunieto!";
            }
            else
            {
                tb_wynik.Text = "Nie odnaleziono!";
            }
        }

        /// <summary>
        /// Metoda obslugujaca przycisk wyszukania tlumaczenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_sea_Click(object sender, RoutedEventArgs e)
        {
               tb_wynik.Text = myClient.searchWord(tb_sea.Text);
        }
    }
}
