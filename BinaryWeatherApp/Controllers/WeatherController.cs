using BinaryWeatherApp.Models;
using BinaryWeatherApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinaryWeatherApp.Controllers
{
	public class WeatherController : Controller
	{
		private Forecast forecast;
		public ActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Index(string city, int days)
		{
			if (!string.IsNullOrWhiteSpace(city))
			{
				WeatherService service = new WeatherService();
				forecast = service.Get(city, days);

				return View(forecast);
			}
			return View();
		}
	}
}
