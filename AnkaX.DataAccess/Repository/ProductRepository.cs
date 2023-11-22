using AnkaX.DataAccess.Data;
using AnkaX.DataAccess.Repository.IRepository;
using AnkaX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AnkaX.DataAccess.Repository
{
   
        public class ProductRepository : Repository<Product>, IProductRepository
    {

        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.Seller = obj.Seller;
                objFromDb.Description = obj.Description;
                objFromDb.SiteAge = obj.SiteAge;
                objFromDb.Industry = obj.Industry;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Location = obj.Location;
                objFromDb.MonthlyNetProfit = obj.MonthlyNetProfit;
                objFromDb.Price = obj.Price;

                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
        }
    }