using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using UWPBinaryWeatherAppClient.Models;
using UWPBinaryWeatherAppClient.Services;

namespace UWPBinaryWeatherAppClient.ViewModels
{
    public class TownsViewModel : ViewModelBase
    {
        public ObservableCollection<TownsModel> Towns { get; set; }
        TownsService townsService = new TownsService();
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public string townAdd { get; set; }
        public TownsModel townDel { get; set; }
        public TownsViewModel()
        {
            Towns = new ObservableCollection<TownsModel>();
            Update();
            AddCommand = new RelayCommand(async()=> { await AddAsync(); });
            DeleteCommand = new RelayCommand(async()=> { await Delete(); });
        }

        void Update()
        {
            Towns.Clear();
            var list = townsService.GetAsync().Result;
            foreach (var n in list)
                Towns.Add(n);
            MessengerInstance.Send(new ObservableCollection<TownsModel>());
        }
        async Task AddAsync()
        {
            await townsService.Add(townAdd);
            Update();
        }
        async Task Delete()
        {
           await townsService.Delete(townDel.TownName);
            Update();
        }
    }
}
