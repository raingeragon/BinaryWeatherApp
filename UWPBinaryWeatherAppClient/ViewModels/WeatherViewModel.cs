using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UWPBinaryWeatherAppClient.Models;
using UWPBinaryWeatherAppClient.Services;

namespace UWPBinaryWeatherAppClient.ViewModels
{
    public class WeatherViewModel : ViewModelBase
    {
        public WeatherModel Forecast { get; set; }
        public ICommand ForecastCommand { get; set; }
        public List<string> Towns { get; private set; }

        public string city;
        public int days;

        public WeatherViewModel ()
        {
            ForecastCommand = new RelayCommand(GetForecast);
            Forecast = new WeatherModel();
            var townsService = new TownsService();
            var townsList = townsService.Get();
            foreach (var n in townsList)
                Towns.Add(n.TownName);

        }
        private void Search()
        {

        }
        public async void GetForecast()
        {
            var service = new WeatherService();
            Forecast = await service.GetForecast(city, days);
            RaisePropertyChanged(() => Forecast);
        }
    }
}
