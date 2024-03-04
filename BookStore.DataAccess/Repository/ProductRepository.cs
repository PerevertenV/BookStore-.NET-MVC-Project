﻿using BookStore.Data;
using BookStore.Models;
using BookStore.DataAccess.Repository.IRepository;

namespace BookStore.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }
        public void Update(Product obj)
        {
           var objFromDb = _db.Products.FirstOrDefault(u=>u.ID == obj.ID);
            if(objFromDb != null) 
            {
                objFromDb.Title = obj.Title;
                objFromDb.Description = obj.Description;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.Author = obj.Author;
                if(obj.ImageUrl != null) 
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}