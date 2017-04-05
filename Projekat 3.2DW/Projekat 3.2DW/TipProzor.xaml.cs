using Microsoft.Win32;
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
using System.ComponentModel;

namespace Projekat_3._2DW
{
    /// <summary>
    /// Interaction logic for TipProzor.xaml
    /// </summary>
    public partial class TipProzor : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }


        
        public string OznakaResurs {
            get;set;
        }

        public TipProzor()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void OdabirKlik(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            if(!fd.FileName.Equals(""))
                putanja.Text = fd.FileName;

        }
    }
}
