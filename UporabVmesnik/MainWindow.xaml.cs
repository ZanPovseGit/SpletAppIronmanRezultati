using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
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
using UporabVmesnik.Models;

namespace UporabVmesnik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly HttpClient client = new HttpClient();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var oseba = await client.GetStreamAsync("https://localhost:44303/api/oseba");
            var listOseb = await JsonSerializer.DeserializeAsync<List<Oseba>>(oseba);
            foreach(Oseba a in listOseb)
            {
                if (a.ime == ime.Text && a.geslo == geslo.Text)
                {
                    if(a.admin == true)
                    {
                        redirecti aa = new redirecti();
                        aa.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Niste admin");
                    }
                }
            }
            MessageBox.Show("Nepravilna prijava");

        }
    }
}
