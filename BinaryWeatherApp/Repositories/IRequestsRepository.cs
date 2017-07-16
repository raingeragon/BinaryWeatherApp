using BinaryWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryWeatherApp.Repositories
{
	public interface IRequestRepository : IRepository<Request>
	{
		List<Request> GetAll();
		Request GetById(int id);
		void Create(Request item);
		void Delete(int id);
		void Edit(Request item);
		void Save();
		void DeleteAll();
	}
}