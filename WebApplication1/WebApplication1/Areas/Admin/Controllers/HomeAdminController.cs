using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Areas.Admin.Code;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        void Out()
        {
            if (SessionHelper.GetSession() == null) Response.Redirect("~/Admin/Login/Index");
        }
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            Out();
            return View();
        }
    }
}