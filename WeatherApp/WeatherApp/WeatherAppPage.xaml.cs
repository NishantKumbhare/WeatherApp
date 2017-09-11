using Xamarin.Forms;
using WeatherApp.Webservice;
using WeatherApp.Model;
using WeatherApp.ViewModel;

namespace WeatherApp
{
    public partial class WeatherAppPage : ContentPage
    {
        public WeatherAppPage()
        {
            InitializeComponent();
        }


        async void weatherButton_ClickedAsync(object sender, System.EventArgs e)
        {
            WeatherAPI api = new WeatherAPI();
            WeatherModel weatherModel = new WeatherModel();
            weatherModel = await api.GetWeatherData();

            var displayValue = "Celsius:- " + weatherModel.current_observation.temp_c + "\n" +
                                                      "Fahrenheit:-" + weatherModel.current_observation.temp_f + "\n" +
                                                      "Time:-" + weatherModel.current_observation.observation_time;

            temperature.Text = displayValue;
            overlay.IsVisible = true;
        }

		void OnOKButtonClicked(object sender, System.EventArgs e)
		{
			overlay.IsVisible = false;
		}

        void showAlertView(string message)
        {

            DisplayAlert("Weather App",
                         message,
                         "Okey");
        }

    }
}
