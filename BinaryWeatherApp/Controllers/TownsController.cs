using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BinaryWeatherApp.Repositories;
using BinaryWeatherApp.Models;

namespace BinaryWeatherApp.Controllers
{
	public class TownsController : Controller
	{
		ITownsRepository townsRepository;
		public TownsController(ITownsRepository itr)
		{
			townsRepository = itr;
		}
		public ActionResult Index()
		{
			var towns = townsRepository.GetAll();
			return View(towns);
		}
		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}

		[HttpGet]
		public ActionResult Edit (int id)
		{
			var town = townsRepository.GetById(id);
			return View(town);
		}

		[HttpPost]
		public ActionResult Create(Town item)
		{
			if (ModelState.IsValid)
			{
				Town town = new Town()
				{
					TownName = item.TownName
				};
				townsRepository.Create(town);
				return RedirectToAction("Index");
			}
			else
			{
				return View(item);
			}
		}
		
		[HttpPost]
		public ActionResult Edit(Town item)
		{
			if (ModelState.IsValid)
			{
				townsRepository.Edit(item);
				return RedirectToAction("Index");
			}
			else
			{
				return View(item);
			}
		}
		public ActionResult Delete(int id)
		{
			townsRepository.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
