using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPBinaryWeatherAppClient.Models;
using UWPBinaryWeatherAppClient.Services;
using System.Windows.Input;

namespace UWPBinaryWeatherAppClient.ViewModels
{
    public class RequestsViewModel : ViewModelBase
    {
        public List<RequestsModel> Requests { get; set; }
        public RequestsViewModel()
        {
            var service = new RequestsService();
            Requests = service.Get().ToList();
            Requests.Reverse();
        }
    }
}
