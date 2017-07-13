using BinaryWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryWeatherApp.Repositories
{
	public interface ITownsRepository : IRepository<Town>
	{
		List<Town> GetAll();
		Town GetById(int id);
		void Create(Town item);
		void Delete(int id);
		void Edit(Town item);
		void Save();
	}
}