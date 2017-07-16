using BinaryWeatherApp.Entities;
using BinaryWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BinaryWeatherApp.Repositories
{
	public class TownsRepository : IRepository<Town>
	{
		private WeatherContext db;
		private bool dispose = false;

		public TownsRepository(WeatherContext weathercontext)
		{
			db = weathercontext;
		}
		public List<Town> GetAll()
		{
			return db.Towns.ToList();
		}
		public Town GetById (int id)
		{
			return db.Towns.Find(id);
		}
		public void  Create (Town town)
		{
			db.Towns.Add(town);
			Save();
		}
		public void Edit(Town item)
		{
			db.Entry(item).State = EntityState.Modified;
			Save();
		}
		public void Delete (int id)
		{
			Town item = db.Towns.Find(id);
			if (item != null)
				db.Towns.Remove(item);
			Save();
		}
		public void DeleteAll()
		{
			db.Towns.RemoveRange(db.Towns);
			Save();
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