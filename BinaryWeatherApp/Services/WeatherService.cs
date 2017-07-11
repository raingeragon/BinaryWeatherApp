using BinaryWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using Newtonsoft.Json;

namespace BinaryWeatherApp.Services
{
	public class WeatherService : IWeatherService
	{
		private string api = "03b4475836684e7572334999a38a5fbf";

		public Forecast Get(string city, int days)
		{
			string url = $"http://api.openweathermap.org/data/2.5/forecast/daily?q={city}&cnt={days}&units=metric&APPID={api}";
			WebClient client = new WebClient();
			string json = @"" + (client.DownloadString(url)).Replace('"', '\'');
			Forecast forecast = new Forecast(JsonConvert.DeserializeObject<RootObject>(json));

			return forecast;
		}
	}
}