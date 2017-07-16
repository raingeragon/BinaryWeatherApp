using BinaryWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BinaryWeatherApp.Repositories
{
	public interface IUnitOfWork : IDisposable
	{
		IRepository<Request> Requests { get; }
		IRepository<Town> Towns { get; }
		void Save();
	}
}