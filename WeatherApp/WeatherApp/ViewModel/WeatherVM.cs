
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
            set => fahrenheit = weatherModel.temp_f;
        }

        private string celsius;
        public string Celsius
        {
            get => celsius;
            set => celsius = weatherModel.temp_c;
		}

        private string time;
        public string Time
        {
            get => time;
            set => time = weatherModel.observation_time;
		}

        public async Task InitializeGetWeatherAsync()
        {
            weatherModel = await weatherAPI.GetWeatherData();

            fahrenheit = weatherModel.temp_f;
            celsius = weatherModel.temp_c;
            time = weatherModel.observation_time;
        }

    }
}

