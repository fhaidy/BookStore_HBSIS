using Bookstore.Data.Context;
using Bookstore.Domain.Entities;
using Bookstore.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Data.Repository
{
	public class BaseRepository<T> : IDisposable, IRepository<T> where T : BaseEntity
	{
		private SqlContext _context;
		private bool disposed = false;

		public BaseRepository(SqlContext context)
		{
			_context = context;
		}

		public T Delete(int id)
		{
			var obj = Select(id) ?? throw new Exception("No data found with id: " + id);

			_context.Set<T>().Remove(obj);
			_context.SaveChanges();

			return obj;
		}

		public T Insert(T obj)
		{
			_context.Set<T>().Add(obj);
			_context.SaveChanges();

			return obj;
		}

		public T Select(int id)
		{
			var obj = _context.Set<T>().Find(id) ?? throw new Exception("No data found with id: " + id);

			return obj;
		}

		public IList<T> SelectAll()
		{
			return _context.Set<T>().ToList();
		}

		public T Update(T obj)
		{
			_context.Entry(obj).State = EntityState.Modified;
			_context.SaveChanges();
			return obj;
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
