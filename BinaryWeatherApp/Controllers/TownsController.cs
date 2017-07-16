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
		IUnitOfWork unitOfWork;
		public TownsController(IUnitOfWork itr)
		{
			unitOfWork = itr;
		}
		public ActionResult Index()
		{
			var towns = unitOfWork.Towns.GetAll();
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
			var town = unitOfWork.Towns.GetById(id);
			return View(town);
		}

		[HttpPost]
		public ActionResult Create(Town item)
		{
			if (ModelState.IsValid && !string.IsNullOrWhiteSpace(item.TownName))
			{
				Town town = new Town()
				{
					TownName = item.TownName
				};
				unitOfWork.Towns.Create(town);
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
			if (ModelState.IsValid && !string.IsNullOrWhiteSpace(item.TownName))
			{
				unitOfWork.Towns.Edit(item);
				return RedirectToAction("Index");
			}
			else
			{
				return View(item);
			}
		}
		public ActionResult Delete(int id)
		{
			unitOfWork.Towns.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
