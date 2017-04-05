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
using System.Windows.Forms;
using System.Drawing;

namespace Projekat_3._2DW
{
    /// <summary>
    /// Interaction logic for EtiketaProzor.xaml
    /// </summary>
    public partial class EtiketaProzor : Window
    {
        public EtiketaProzor()
        {
            InitializeComponent();
        }


        private void DajBoje(object sender, RoutedEventArgs e)
        {
            ColorDialog cd = new ColorDialog();


            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var wpfColor = System.Windows.Media.Color.FromArgb(cd.Color.A, cd.Color.R, cd.Color.G, cd.Color.B);
                var brush = new SolidColorBrush(wpfColor);
                dugmeBoja.Background = brush;

            }

        }
    }
}
