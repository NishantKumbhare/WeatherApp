using Xamarin.Forms;

namespace WeatherApp
{
    public partial class WeatherAppPage : ContentPage
    {
        public WeatherAppPage()
        {
            InitializeComponent();
        }


        void weatherButton_ClickedAsync(object sender, System.EventArgs e)
        {
            overlay.IsVisible = true;
        }

		void OnOKButtonClicked(object sender, System.EventArgs e)
		{
			overlay.IsVisible = false;
		}

    }
}
