using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication1.Areas.Admin.Code
{
    public class Check
    {
        public static void Out()
        {
            if(HttpContext.Current.Session["loginSession"]==null)
            HttpContext.Current.Response.Redirect("/Admin/Login");
        }
    }
}