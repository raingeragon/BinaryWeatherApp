using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using UWPBinaryWeatherAppClient.Models;
using System.Net.Http;

namespace UWPBinaryWeatherAppClient.Services
{
    public class TownsService
    {
        private string apiPath;
        private HttpClient client;
        public TownsService()
        {
            apiPath = "http://localhost:59524/api/";
            client = new HttpClient();
        }

        public IEnumerable<TownsModel> Get()
        {
            var response = client.GetAsync($"{apiPath}Towns").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            return JsonConvert.DeserializeObject<IEnumerable<TownsModel>>(result);
        }

        public async void Add(string name)
        {
            await client.PostAsync($"{apiPath}Towns/?city={name}",null);
        }

        public async void Delete(string name)
        {
            await client.DeleteAsync($"{apiPath}Towns/city={name}");
        }
    }
}
