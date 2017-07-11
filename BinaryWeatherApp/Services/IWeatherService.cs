using BinaryWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryWeatherApp.Services
{
	public interface IWeatherService
	{
		Forecast Get(string city, int days);
	}
}