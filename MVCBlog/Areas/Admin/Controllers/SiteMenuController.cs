using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBlog.Areas.Admin.Models.DTO;
using MVCBlog.Models.ORM.Entity;
namespace MVCBlog.Areas.Admin.Controllers
{
    public class SiteMenuController : BaseController
    {
        // GET: Admin/SiteMenu
     
        public ActionResult AddSiteMenu()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddSiteMenu(SiteMenuVm model)
        {
            SiteMenu sitemenu = new SiteMenu();
            sitemenu.Name = model.Name;
            sitemenu.Url = model.Url;
            sitemenu.cssClass = model.cssClass;
            db.SiteMenus.Add(sitemenu);
            db.SaveChanges();
            ViewBag.IslemDurum = 1;

            return View();
        }
    }
}