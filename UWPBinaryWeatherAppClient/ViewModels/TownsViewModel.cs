using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows.Input;
using UWPBinaryWeatherAppClient.Models;
using UWPBinaryWeatherAppClient.Services;

namespace UWPBinaryWeatherAppClient.ViewModels
{
    public class TownsViewModel : ViewModelBase
    {
        public ObservableCollection<TownsModel> Towns { get; private set; }
        TownsService townsService = new TownsService();
        public ICommand AddCommand { get; set; }
        public string name { get; set; }
        public TownsViewModel()
        {
            Towns = new ObservableCollection<TownsModel>();
            Update();
            AddCommand = new RelayCommand(Add);
        }

        void Update()
        {
            Towns.Clear();
            var list = townsService.Get();
            foreach (var n in list)
                Towns.Add(n);
            MessengerInstance.Send(new ObservableCollection<TownsModel>());
        }
        void Add()
        {
            townsService.Add(name);
            Update();
        }

    }
}
