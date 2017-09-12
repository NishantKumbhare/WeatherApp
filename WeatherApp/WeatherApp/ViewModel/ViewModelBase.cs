
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WeatherApp.ViewModel
{
    public class VIewModelBase : INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
    }
}

