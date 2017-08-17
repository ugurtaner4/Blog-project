using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlog.Models.ORM.Entity
{
    public class AdminUser : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        [Required]
        [StringLength(30)]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}