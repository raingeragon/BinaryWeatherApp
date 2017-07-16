﻿using BinaryWeatherApp.Models;
using BinaryWeatherApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using BinaryWeatherApp.Repositories;

namespace BinaryWeatherApp.Controllers
{
	public class WeatherController : Controller
	{
		IWeatherService weatherService;
		IUnitOfWork unitOfWork;
		

		public WeatherController(IWeatherService iws, IUnitOfWork iuow)
		{
			weatherService = iws;
			unitOfWork = iuow;
			var towns = unitOfWork.Towns.GetAll();

			ViewBag.Towns = towns;
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
				Forecast forecast = weatherService.Get(city, days);
				Request request = new Request
				{
					RequestTown = forecast.city,
					RequestDays = days,
					RequestDate = forecast.GetDailyList()[0].date,
					RequestImg = forecast.GetDailyList()[0].icon,
					RequestTemp = forecast.GetDailyList()[0].day 
				};
				unitOfWork.Requests.Create(request);
				return View(forecast);
			}
			return View();
		}
	}
}
