﻿
using BookStore.Data;
using BookStore.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
	public class UnitOFWork : IUnitOfWork
	{
		private ApplicationDbContext _db;
		public ICategoryRepository Category { get; private set; }
		public IProductRepository Product { get; private set; }

		public UnitOFWork(ApplicationDbContext db)
		{
			_db = db;
			Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);

        }

		public void save()
		{
			_db.SaveChanges();
		}
	}
}
