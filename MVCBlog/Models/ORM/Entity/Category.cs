using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlog.Models.ORM.Entity
{
    public class Category  : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<BlogPost> BlogPosts { get; set; }
    }
}