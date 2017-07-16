using BinaryWeatherApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinaryWeatherApp.Controllers
{
	public class RequestsController : Controller
	{
		IUnitOfWork unitOfWork;
		public RequestsController(IUnitOfWork iuow)
		{
			unitOfWork = iuow;
		}
		public ActionResult Index()
		{
			var requests = unitOfWork.Towns.GetAll();
			return View(requests);
		}
	}
}
