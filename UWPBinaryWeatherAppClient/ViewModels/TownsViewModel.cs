﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
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
            AddCommand = new RelayCommand(Add);
            DeleteCommand = new RelayCommand(Delete);
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
            townsService.Add(townAdd);
            Update();
        }
        void Delete()
        {
            townsService.Delete(townDel.TownName);
            Update();
        }
    }
}
