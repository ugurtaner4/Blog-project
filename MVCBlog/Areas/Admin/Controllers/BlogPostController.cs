using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlog.Areas.Admin.Models.DTO;
using MVCBlog.Models.ORM.Entity;
using MVCBlog.Areas.Admin.Models.Services.HTMLDataSourceServices;
namespace MVCBlog.Areas.Admin.Controllers
{
    public class BlogPostController : BaseController
    {
        public ActionResult Index()
        {
            List<BlogPostVM> model = db.BlogPosts.Where(x => x.IsDeleted == false).OrderBy(x =>
            x.AddDate).Select(x => new BlogPostVM()
            {
                Title = x.Title,
                CategoryName = x.Category.Name,
                ID = x.ID
            }).ToList();

            return View(model);
        }
        public ActionResult AddBlogPost()
        {
            BlogPostVM model = new BlogPostVM();
            model.drpCategories = DrpServices.getDrpCategories();
            return View(model);
        }
        [ValidateInput(false)]
        [HttpPost]
        public ActionResult AddBlogPost(BlogPostVM model)
        {
            BlogPostVM vmodel = new BlogPostVM();
            vmodel.drpCategories = DrpServices.getDrpCategories();
            if (ModelState.IsValid)
            {
                BlogPost blogpost = new BlogPost();
                blogpost.CategoryID = model.CategoryID;
                blogpost.Title = model.Title;
                blogpost.Content = model.Content;
                blogpost.AddDate = DateTime.Now;
                blogpost.IsDeleted = false;

                db.BlogPosts.Add(blogpost);
                db.SaveChanges();
                ViewBag.IslemDurum = 1;
                return View(vmodel);
            }
            else
            {
                ViewBag.IslemDurum = 2;
                return View();
            }
            
        }
        public JsonResult DeleteBlogPost(int id)
        {
            BlogPost blogpost = db.BlogPosts.FirstOrDefault(x => x.ID == id);
            blogpost.IsDeleted = true;
            blogpost.DeleteDate = DateTime.Now;
            db.SaveChanges();
            return Json("");

        }
        public ActionResult UpdateBlogPost(int id)
        {
            
            
            BlogPost blog = db.BlogPosts.FirstOrDefault(x => x.ID == id);
            BlogPostVM vmodel = new BlogPostVM();
            
            vmodel.Title = blog.Title;
            vmodel.drpCategories = DrpServices.getDrpCategories();
            vmodel.CategoryName = blog.Category.Name;
            vmodel.Content = blog.Content;

            return View(vmodel);
        }
        [HttpPost]
        public ActionResult UpdateBlogPost(BlogPostVM model)
        {
            
            if (ModelState.IsValid)
            {
                BlogPost blog = db.BlogPosts.FirstOrDefault(x => x.ID == model.ID);
                blog.Title = model.Title;
                blog.Content = model.Content;
                db.SaveChanges();
                ViewBag.IslemDurum = 1;
                return View();
            }
            else
            {
                ViewBag.IslemDurum = 2;
                return View();
            }
           
        }
    }
}