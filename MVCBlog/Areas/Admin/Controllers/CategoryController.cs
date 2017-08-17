﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlog.Areas.Admin.Models.DTO;
using MVCBlog.Models.ORM.Entity;
namespace MVCBlog.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(CategoryVM model)
        {
            if (ModelState.IsValid)
            {
                Category category = new Category();
                category.Name = model.Name;
                category.Description = model.Description;
                db.Categories.Add(category);
                db.SaveChanges();
                return View();
            }
            else
            {
                return View();
            }
            
        }
    }
}