﻿using Microsoft.AspNetCore.Mvc;
using Mobile_Application_Sales_Site.Data;
using Mobile_Application_Sales_Site.Models;

namespace Mobile_Application_Sales_Site.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
         public CategoryController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
            }
           
            return RedirectToAction("Index");
        }
    }
}
