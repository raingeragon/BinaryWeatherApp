using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryWeatherApp.Repositories
{
	public interface IRepository<T> :IDisposable
		where T : class
	{
		List<T> GetAll();
		T GetById(int id);
		void Create(T item);
		void Delete(int id);
		void Edit(T item);
		void Save();
	}
}
