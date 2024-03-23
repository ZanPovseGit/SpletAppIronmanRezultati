using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Windows;
using UporabVmesnik.Models;

namespace UporabVmesnik
{
    /// <summary>
    /// Interaction logic for ocebc.xaml
    /// </summary>
    public partial class ocebc : Window
    {
        private static readonly HttpClient client = new HttpClient();
        public ocebc()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringi = await client.GetStreamAsync("https://localhost:44303/api/oseba");
            var objek = await JsonSerializer.DeserializeAsync<List<Oseba>>(stringi);
            ayy.ItemsSource = objek;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string vrni = String.Empty;
            Oseba man = (Oseba)ayy.SelectedItem;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent vsebina = new StringContent(JsonSerializer.Serialize(man));
            vsebina.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponse = await client.PostAsync("https://localhost:44303/api/oseba", vsebina);
            if (httpResponse.IsSuccessStatusCode)
                vrni = httpResponse.StatusCode.ToString();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Oseba man = (Oseba)ayy.SelectedItem;
            string id = man.id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            StringContent vsebina = new StringContent(JsonSerializer.Serialize(man));
            vsebina.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponse = await client.PutAsync("https://localhost:44303/api/oseba/" + id, vsebina);
            if (httpResponse.IsSuccessStatusCode)
                MessageBox.Show(httpResponse.StatusCode.ToString());
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string vrni = String.Empty;
            var a = ayy.SelectedItem;
            Oseba man = (Oseba)ayy.SelectedItem;
            string id = man.id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpResponse = await client.DeleteAsync("https://localhost:44303/api/oseba/" + id);
            if (httpResponse.IsSuccessStatusCode)
                MessageBox.Show(httpResponse.StatusCode.ToString());
        }
    }
}
