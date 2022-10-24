using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json;

namespace TP03
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Login();
        }

        public async void Login()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://stormy-gorge-46346.herokuapp.com/Logins");
            var login = JsonConvert.DeserializeObject<List<Login>>(response);
            ListLogin.ItemsSource = login;
        }
    }
}
