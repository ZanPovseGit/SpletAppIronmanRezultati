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
    /// Interaction logic for ironman7.xaml
    /// </summary>
    public partial class ironman7 : Window
    {
        private static readonly HttpClient client = new HttpClient();
        public ironman7()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringi = await client.GetStreamAsync("https://localhost:44303/api/ironman703");
            var objek = await JsonSerializer.DeserializeAsync<List<ironman703>>(stringi);
            ayy.ItemsSource = objek;
            
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string vrni = String.Empty;
            ironman703 man = (ironman703)ayy.SelectedItem;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            StringContent vsebina = new StringContent(JsonSerializer.Serialize(man));
            vsebina.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponse = await client.PostAsync("https://localhost:44303/api/ironman703", vsebina);
            if (httpResponse.IsSuccessStatusCode)
                vrni = httpResponse.StatusCode.ToString();

        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string vrni = String.Empty;
            var a = ayy.SelectedItem;
            ironman703 man = (ironman703)ayy.SelectedItem;
            string id = man.id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpResponse = await client.DeleteAsync("https://localhost:44303/api/ironman703/"+id);
            if (httpResponse.IsSuccessStatusCode)
                MessageBox.Show(httpResponse.StatusCode.ToString());
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ironman703 man = (ironman703)ayy.SelectedItem;
            string id = man.id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            StringContent vsebina = new StringContent(JsonSerializer.Serialize(man));
            vsebina.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponse = await client.PutAsync("https://localhost:44303/api/ironman703/"+id, vsebina);
            if (httpResponse.IsSuccessStatusCode)
                MessageBox.Show(httpResponse.StatusCode.ToString());
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringi = await client.GetStreamAsync("https://localhost:44303/api/ironman703" + id.Text);
            var objek = await JsonSerializer.DeserializeAsync<ironman703>(stringi);
            List<ironman703> aa = new List<ironman703> { objek };
            ayy.ItemsSource = aa;
        }
    }
}
