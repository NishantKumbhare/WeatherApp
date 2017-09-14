using Xamarin.Forms;
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
            WeatherVM weatherVM = new WeatherVM();
            await weatherVM.InitializeGetWeatherAsync();
            fahren.Text = "Fahrenheit:- " + weatherVM.Fahrenheit;
            cel.Text = "Celsius:- " + weatherVM.Celsius;
            tm.Text = "Recorded Time:- " + weatherVM.Time;
            overlay.IsVisible = true;
        }

        void OnOKButtonClicked(object sender, System.EventArgs e)
		{
			overlay.IsVisible = false;
		}

    }
}
