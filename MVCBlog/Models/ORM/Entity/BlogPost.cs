using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCBlog.Models.ORM.Entity
{
    public class BlogPost:BaseEntity
    {
        public string Title { get; set; }

        public string Content { get; set; }
        
        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
    }
}