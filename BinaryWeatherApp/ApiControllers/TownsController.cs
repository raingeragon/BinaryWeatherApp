using BinaryWeatherApp.Models;
using BinaryWeatherApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BinaryWeatherApp.ApiControllers
{
	public class TownsController : ApiController
	{
		IUnitOfWork unitOfWork;
		public TownsController(IUnitOfWork iuow)
		{
			unitOfWork = iuow;
		}
		public TownsController()
		{
			unitOfWork = new UnitOfWork("WeatherContext");
		}

		// Post api/Towns/?city=TownName
		[HttpPost]
		public HttpResponseMessage Create(string name)
		{
			if (!string.IsNullOrWhiteSpace(name))
			{
				unitOfWork.Towns.Create(new Town { TownName = name });
				return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
			}
			return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
		}

		//Get api/Towns
		[HttpGet]
		public List<Town> GetAll()
		{
			return unitOfWork.Towns.GetAll();
		}

		//Delete api/Towns/id
		[HttpDelete]
		public HttpResponseMessage Delete(int id)
		{
			if (unitOfWork.Towns.GetById(id) != null)
			{
				unitOfWork.Towns.Delete(id);
				return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
			}
			return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
		}

		//Delete api/Towns/?city=TownName
		[HttpDelete]
		public HttpResponseMessage Delete(string townname)
		{
			var town = unitOfWork.Towns.GetAll().FirstOrDefault(x => x.TownName == townname);
			if (town != null)
			{
				unitOfWork.Towns.Delete(town.TownId);
				return new HttpResponseMessage() { StatusCode = HttpStatusCode.OK };
			}
			return new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };
		}

	}
}
