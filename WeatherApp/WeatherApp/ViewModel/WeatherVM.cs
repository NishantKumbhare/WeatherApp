
using WeatherApp.Model;
using System.Threading.Tasks;
using WeatherApp.Webservice;

namespace WeatherApp.ViewModel
{
    
    public class WeatherVM : VIewModelBase
    {

        WeatherAPI weatherAPI = new WeatherAPI();

        private WeatherModel weatherModel;

		public WeatherModel WeatherModel
		{
			get { return weatherModel; }
			set
			{
				weatherModel = value;
				OnPropertyChanged();
			}
		}

		private string fahrenheit;
		public string Fahrenheit {
            get => fahrenheit;
            set => fahrenheit = WeatherModel.temp_f;
        }

        public string Celsius
        {
            get => Celsius;
            set => Celsius = WeatherModel.temp_c;
		}

        public string Time
        {
            get => Time;
            set => Time = WeatherModel.observation_time;
		}

        public async Task InitializeGetWeatherAsync()
        {
            weatherModel = await weatherAPI.GetWeatherData();
        }

    }
}

