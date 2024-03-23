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
    /// Interaction logic for ironman.xaml
    /// </summary>
    public partial class ironman : Window
    {
        private static readonly HttpClient client = new HttpClient();
        public ironman()
        {
            InitializeComponent();
        }

        private async Task Button_ClickAsync(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringi = await client.GetStreamAsync("https://localhost:44303/api/ironman");
            var objek = await JsonSerializer.DeserializeAsync<List<ironmanc>>(stringi);
            ayy.ItemsSource = objek;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {

            string vrni = String.Empty;
            ironmanc man = (ironmanc)ayy.SelectedItem;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent vsebina = new StringContent(JsonSerializer.Serialize(man));
            vsebina.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponse = await client.PostAsync("https://localhost:44303/api/ironman", vsebina);
            if (httpResponse.IsSuccessStatusCode)
                vrni = httpResponse.StatusCode.ToString();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ironmanc man = (ironmanc)ayy.SelectedItem;
            string id = man.id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            StringContent vsebina = new StringContent(JsonSerializer.Serialize(man));
            vsebina.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponse = await client.PutAsync("https://localhost:44303/api/ironman/" + id, vsebina);
            if (httpResponse.IsSuccessStatusCode)
                MessageBox.Show(httpResponse.StatusCode.ToString());
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string vrni = String.Empty;
            var a = ayy.SelectedItem;
            ironmanc man = (ironmanc)ayy.SelectedItem;
            string id = man.id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpResponse = await client.DeleteAsync("https://localhost:44303/api/ironman/" + id);
            if (httpResponse.IsSuccessStatusCode)
                MessageBox.Show(httpResponse.StatusCode.ToString());

        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringi = await client.GetStreamAsync("https://localhost:44303/api/ironman");
            var objek = await JsonSerializer.DeserializeAsync<List<ironmanc>>(stringi);
            ayy.ItemsSource = objek;
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringi = await client.GetStreamAsync("https://localhost:44303/api/ironman/" + id.Text);
            var objek = await JsonSerializer.DeserializeAsync<ironmanc>(stringi);
            List<ironmanc> aa = new List<ironmanc> { objek };            
            ayy.ItemsSource = aa;
        }
    }
}
