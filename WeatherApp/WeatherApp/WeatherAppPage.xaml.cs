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

        }

        void showAlertView(string message)
        {

            DisplayAlert("Weather App",
                         message,
                         "Okey");
        }

    }
}
