using BinaryWeatherApp.Models;
using BinaryWeatherApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace BinaryWeatherApp.ApiControllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class RequestsController : ApiController
	{
		IUnitOfWork unitofWork;
		public RequestsController()
		{
			unitofWork = new UnitOfWork("WeatherContext");
		}
		public RequestsController(UnitOfWork uow)
		{
			unitofWork = uow;
		}

		//Get api/Requests
		[HttpGet]
		public async Task<List<Request>> Get()
		{
			return await  unitofWork.Requests.GetAllAsync();
		}
	}
}
