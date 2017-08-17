using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlog.Areas.Admin.Models.DTO
{
    public class CategoryVM : BaseVM
    {
        [Required(ErrorMessage ="Kategori Giriniz")]
        [Display(Name="Ad")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        
    }
}