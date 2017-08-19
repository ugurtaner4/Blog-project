using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
namespace MVCBlog.Areas.Admin.Models.DTO
{
    public class BlogPostVM : BaseVM 
    {
        public string Title { get; set; }

        public string Content { get; set; }
        [Required]
        public int CategoryID { get; set; }

        public IEnumerable<SelectListItem> drpCategories { get; set; }
    }
}