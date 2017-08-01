using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public ICommand DeleteCommand { get; set; }
        public string name;
        public TownsViewModel()
        {
            Towns = new ObservableCollection<TownsModel>();
            Update();
            AddCommand = new RelayCommand(Add);
            DeleteCommand = new RelayCommand(Delete);
        }

        void Update()
        {
            Towns.Clear();
            var list = townsService.Get();
            foreach (var n in list)
                Towns.Add(n);
        }
        void Add()
        {
            townsService.Add(name);
            Update();
        }
        void Delete()
        {
            townsService.Delete(name);
            Update();
        }
    }
}
