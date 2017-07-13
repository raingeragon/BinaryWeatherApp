﻿using BinaryWeatherApp.Entities;
using BinaryWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinaryWeatherApp.Controllers
{
	public class HomeController : Controller
	{

		public ActionResult Index()
		{
			return RedirectToAction("Index", "Weather");
		}
	}
}