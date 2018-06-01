using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Nhập UserName")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "Nhập Password")]
        public string Password { set; get; }
        
    }
}