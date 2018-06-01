using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Areas.Admin.Code;
<<<<<<< HEAD
using WebApplication1.Areas.Admin.Models;
=======
>>>>>>> 7e155ee1e2a4eafaa2579166764fedadbbcb5f8f
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
<<<<<<< HEAD
            ViewBag.Text = Session["loginSession"];
=======
            Out();
>>>>>>> 7e155ee1e2a4eafaa2579166764fedadbbcb5f8f
            return View();
        }
        //[HttpPost]
        //public ActionResult Index(AccountModel model)
        //{
            
        //    //SessionHelper.GetSession();
        //    ViewBag.Text = Session["loginSession"];
        //    return View("Index");
        //}
    }
}