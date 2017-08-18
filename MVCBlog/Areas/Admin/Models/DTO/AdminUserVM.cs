using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlog.Areas.Admin.Models.DTO
{
    public class AdminUserVM : BaseVM
    {
        [Required(ErrorMessage = "İsim Giriniz")]
        [Display(Name = "Ad")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Giriniz")]
        [Display(Name = "Soyad")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Email Giriniz")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Giriniz")]
        [Display(Name = "Şifre")]
        public string Password { get; set; }
    }
}