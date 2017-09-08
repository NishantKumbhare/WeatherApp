using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using WeatherApp.Constant;
using WeatherApp.Model;

namespace WeatherApp.Webservice
{
    public class WeatherAPI : ContentPage
    {
        public WeatherAPI()
        {
            
        }

        public async Task<WeatherModel> GetWeatherData()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(Weather.URLBASE);
            var response = await client.GetAsync(Weather.APIKEY+Weather.URLWEATHER);
            var weatherJson = response.Content.ReadAsStringAsync().Result;
            System.Diagnostics.Debug.WriteLine("response::- " + weatherJson);

            WeatherModel weatherModel = new WeatherModel();
            if (weatherJson != null){
                weatherModel  = JsonConvert.DeserializeObject<WeatherModel>(weatherJson);
                System.Diagnostics.Debug.WriteLine("Fahrenheit:- " + weatherModel.current_observation.temp_f);
                System.Diagnostics.Debug.WriteLine("Celsius:- " + weatherModel.current_observation.temp_c);
                System.Diagnostics.Debug.WriteLine("Request Time:- " + weatherModel.current_observation.observation_time_rfc822);
            }
            return weatherModel;
        }
    }
}

