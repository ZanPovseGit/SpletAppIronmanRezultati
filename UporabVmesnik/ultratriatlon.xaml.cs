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
    /// Interaction logic for ultratriatlon.xaml
    /// </summary>
    public partial class ultratriatlon : Window
    {
        private static readonly HttpClient client = new HttpClient();
        public ultratriatlon()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringKnjige = await client.GetStreamAsync("https://localhost:44303/api/ultratriatlon");
            var knjige = await JsonSerializer.DeserializeAsync<List<ultratriatlonc>>(stringKnjige);
            ayy.ItemsSource = knjige;
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string vrni = String.Empty;
            ultratriatlonc man = (ultratriatlonc)ayy.SelectedItem;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            StringContent vsebina = new StringContent(JsonSerializer.Serialize(man));
            vsebina.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponse = await client.PostAsync("https://localhost:44303/api/ultratriatlon", vsebina);
            if (httpResponse.IsSuccessStatusCode)
                vrni = httpResponse.StatusCode.ToString();
        }

        private async void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string vrni = String.Empty;
            var a = ayy.SelectedItem;
            ultratriatlonc man = (ultratriatlonc)ayy.SelectedItem;
            string id = man.id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage httpResponse = await client.DeleteAsync("https://localhost:44303/api/ultratriatlon/" + id);
            if (httpResponse.IsSuccessStatusCode)
                MessageBox.Show(httpResponse.StatusCode.ToString());
        }

        private async void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ultratriatlonc man = (ultratriatlonc)ayy.SelectedItem;
            string id = man.id;
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            StringContent vsebina = new StringContent(JsonSerializer.Serialize(man));
            vsebina.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            HttpResponseMessage httpResponse = await client.PutAsync("https://localhost:44303/api/ultratriatlon/" + id, vsebina);
            if (httpResponse.IsSuccessStatusCode)
                MessageBox.Show(httpResponse.StatusCode.ToString());
        }

        private async void Button_Click_4(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringi = await client.GetStreamAsync("https://localhost:44303/api/ultratriatlon"+ id.Text);
            var iron = await JsonSerializer.DeserializeAsync<ultratriatlonc>(stringi);
            List<ultratriatlonc> aa = new List<ultratriatlonc> { iron };
            ayy.ItemsSource = aa;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
