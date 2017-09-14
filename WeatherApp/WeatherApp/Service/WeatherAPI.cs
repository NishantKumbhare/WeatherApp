using System;
using Newtonsoft.Json;
using System.Net.Http;
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
			using (var client = new HttpClient())
			{
				client.BaseAddress = new Uri(Weather.URLBASE);
				var response = await client.GetAsync(Weather.APIKEY + Weather.URLWEATHER);
				var weatherJson = response.Content.ReadAsStringAsync().Result;
				System.Diagnostics.Debug.WriteLine("response::- " + weatherJson);

				WeatherModel weatherModel = new WeatherModel();
				if (weatherJson != null)
				{
					dynamic jObj = JsonConvert.DeserializeObject(weatherJson);
                    weatherModel.observation_time = (string)jObj["current_observation"]["observation_time"];
                    weatherModel.temp_c = (string)jObj["current_observation"]["temp_c"];
                    weatherModel.temp_f = (string)jObj["current_observation"]["temp_f"];

					System.Diagnostics.Debug.WriteLine("Fahrenheit:- " + weatherModel.temp_f);
					System.Diagnostics.Debug.WriteLine("Celsius:- " + weatherModel.temp_c);
					System.Diagnostics.Debug.WriteLine("Request Time:- " + weatherModel.observation_time);
				}

                return weatherModel;
			}
           
        }
    }
}

