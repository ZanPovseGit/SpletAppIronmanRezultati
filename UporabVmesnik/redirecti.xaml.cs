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

namespace UporabVmesnik
{
    /// <summary>
    /// Interaction logic for redirecti.xaml
    /// </summary>
    public partial class redirecti : Window
    {
        public redirecti()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ironman aa = new ironman();
            aa.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ironman7 aa = new ironman7();
            aa.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ultratriatlon aa = new ultratriatlon();
            aa.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ocebc aa = new ocebc();
            aa.ShowDialog();

        }
    }
}
