using System;
using WeatherApp.Model;
using Xamarin.Forms;

namespace WeatherApp.ViewModel
{
    public class WeatherVM
    {
        public string Fahrenheit {
            get => Fahrenheit;
            set => Fahrenheit = new WeatherModel().current_observation.temp_c;
        }

        public string Celsius
        {
            get => Celsius;
            set => Celsius = new WeatherModel().current_observation.temp_c;
        }

        public string Time
        {
            get => Time;
            set => Time = new WeatherModel().current_observation.observation_time_rfc822;
        }

    }
}

