using BinaryWeatherApp.Entities;
using BinaryWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BinaryWeatherApp.Repositories
{
	public class RequestsRepository : IRepository<Request>
	{
		private WeatherContext db;
		private bool dispose = false;

		public RequestsRepository(WeatherContext weathercontext)
		{
			db = weathercontext;
		}
		public List<Request> GetAll()
		{
			return db.Requests.ToList();
		}
		public Request GetById(int id)
		{
			return db.Requests.Find(id);
		}
		public void Create(Request request)
		{
			db.Requests.Add(request);
			Save();
		}
		public void Delete(int id)
		{
			Request item = db.Requests.Find(id);
			if (item != null)
				db.Requests.Remove(item);
			Save();
		}
		public void Edit(Request item)
		{
			db.Entry(item).State = EntityState.Modified;
			Save();
		}
		public void DeleteAll()
		{
			db.Towns.RemoveRange(db.Towns);
			db.SaveChanges();
		}
		public void Save()
		{
			db.SaveChanges();
		}
		public virtual void Dispose(bool disposing)
		{
			if (!dispose)
			{
				if (disposing)
				{
					db.Dispose();
				}
			}
			dispose = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}