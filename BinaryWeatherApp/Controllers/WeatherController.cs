using BinaryWeatherApp.Models;
using BinaryWeatherApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;

namespace BinaryWeatherApp.Controllers
{
	public class WeatherController : Controller
	{
		IWeatherService WeatherService;
		public WeatherController(IWeatherService iws)
		{
			WeatherService = iws;
		}
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(string city, int days)
		{
			if (!string.IsNullOrWhiteSpace(city))
			{
				Forecast forecast = WeatherService.Get(city, days);

				return View(forecast);
			}
			return View();
		}
	}
}
