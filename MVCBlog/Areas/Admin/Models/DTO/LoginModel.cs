using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MVCBlog.Areas.Admin.Models.DTO
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Lütfen email adresini doldurunuz")]
        [EmailAddress(ErrorMessage ="Lütfen Düzgün Bir Email Adresi Giriniz")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Parolayı doldurunuz")]
        public string Password { get; set; }
    }
}