using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Areas.Admin.Code;
using WebApplication1.Areas.Admin.Models;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class HomeAdminController : Controller
    {
        // GET: Admin/HomeAdmin
        public ActionResult Index()
        {
            ViewBag.Text = Session["loginSession"];
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