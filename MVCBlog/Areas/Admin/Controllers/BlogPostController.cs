using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlog.Areas.Admin.Models.DTO;
namespace MVCBlog.Areas.Admin.Controllers
{
    public class BlogPostController : BaseController
    {
        // GET: Admin/BlogPost
        public ActionResult AddBlogPost()
        {
            BlogPostVM model = new BlogPostVM();
            model.drpCategories = db.Categories.Select(x => new SelectListItem()
            {
                Text = x.Name,
                Value = x.ID.ToString()
            }).ToList();
            return View(model);
        }
        [HttpPost]
        public ActionResult AddBlogPost(BlogPostVM model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.IslemDurum = 1;
            }
            return View();
        }
    }
}