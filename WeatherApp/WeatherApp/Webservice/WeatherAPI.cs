using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using WeatherApp.Constant;

namespace WeatherApp.Webservice
{
    public class WeatherAPI : ContentPage
    {
        public WeatherAPI()
        {
            
        }

        public async Task GetWeatherData()
        {
            var client = new System.Net.Http.HttpClient();
            client.BaseAddress = new Uri(WeatherConstant.URLBASE);
            var response = await client.GetAsync(WeatherConstant.APIKEY+WeatherConstant.URLWEATHER);
            var weatherJson = response.Content.ReadAsStringAsync().Result;
            System.Diagnostics.Debug.WriteLine("response::- " + weatherJson);
        }
    }
}

