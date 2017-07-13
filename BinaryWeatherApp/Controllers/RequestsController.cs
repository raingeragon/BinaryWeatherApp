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
		IRequestRepository requestRepository;
		public RequestsController(IRequestRepository irr)
		{
			requestRepository = irr;
		}
		public ActionResult Index()
		{
			var requests = requestRepository.GetAll();
			return View(requests);
		}
	}
}
