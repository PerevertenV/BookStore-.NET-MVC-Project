
using BookStore.Data;
using JustStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustStore.DataAccess.Repository
{
	public class UnitOFWork : IUnitOfWork
	{
		private ApplicationDbContext _db;
		public ICategoryRepository Category { get; private set; }

		public UnitOFWork(ApplicationDbContext db)
		{
			_db = db;
			Category = new CategoryRepository(_db);
		}

		public void save()
		{
			_db.SaveChanges();
		}
	}
}
