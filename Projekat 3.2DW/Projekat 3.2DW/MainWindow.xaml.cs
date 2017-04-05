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

namespace Projekat_3._2DW
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            //Window1 win1 = new Window1();
            //win1.Show();

            DodajProzor dp = new DodajProzor();
            dp.Show();
        }


        private void Etiketa_klik(object sender, RoutedEventArgs e)
        {
            EtiketaProzor ep = new EtiketaProzor();
            ep.Show();
        }

        private void Tip_klik(object sender, RoutedEventArgs e)
        {
            TipProzor tp = new TipProzor();
            tp.Show();
        }
    }
}
