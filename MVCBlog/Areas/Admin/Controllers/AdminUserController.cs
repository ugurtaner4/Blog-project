using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlog.Areas.Admin.Models.DTO;
using MVCBlog.Models.ORM.Entity;
namespace MVCBlog.Areas.Admin.Controllers
{
    public class AdminUserController : BaseController
    {
        // GET: Admin/AdminUser
        public ActionResult Index()
        {
            
            List<AdminUserVM> model = db.AdminUsers.Where(x => x.IsDeleted == false).OrderBy(x => x.AddDate).Select(x => new AdminUserVM()
            {
                Name = x.Name,
                SurName = x.SurName,
                Email = x.Email,
                Password = x.Password,
                ID = x.ID
            }).ToList();
            return View(model);
        }
        public ActionResult AddAdmin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddAdmin(AdminUserVM model)
        {
            if (ModelState.IsValid)
            {
                AdminUser admin = new AdminUser();
                admin.Name = model.Name;
                admin.SurName = model.SurName;
                admin.Email = model.Email;
                admin.Password = model.Password;
                db.AdminUsers.Add(admin);
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
        public JsonResult DeleteAdmin(int id)
        {
            AdminUser admin = db.AdminUsers.FirstOrDefault(x => x.ID == id);
            admin.IsDeleted = true;
            admin.DeleteDate = DateTime.Now;
            db.SaveChanges();
            return Json("");
        }
        public ActionResult UpdateAdmin(int id)
        {
            AdminUser admin = db.AdminUsers.FirstOrDefault(x => x.ID == id);
            AdminUserVM model = new AdminUserVM();
            model.Name = admin.Name;
            model.SurName = admin.SurName;
            model.Email = admin.Email;
            model.Password = admin.Password;
            return View(model);
        }
        [HttpPost]
        public ActionResult UpdateAdmin(AdminUserVM model)
        {
            if (ModelState.IsValid)
            {
                AdminUser admin = db.AdminUsers.FirstOrDefault(x => x.ID == model.ID);
                admin.Name = model.Name;
                admin.SurName = model.SurName;
                admin.Email = model.Email;
                admin.Password = model.Password;
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