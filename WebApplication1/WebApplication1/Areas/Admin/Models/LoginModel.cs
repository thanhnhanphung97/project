﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string UserName { set; get; }
        public string Password { set; get; }
    }
}