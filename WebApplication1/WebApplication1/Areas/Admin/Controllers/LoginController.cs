using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Areas.Admin.Code;
using WebApplication1.Areas.Admin.Models;
using WebApplication1.Models;
namespace WebApplication1.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        
        dataEntities db = new dataEntities();
        // GET: Admin/Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            var result = new AccountModel().Login(model.UserName, model.Password);
            if(result && ModelState.IsValid)
            {
                SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                Session["loginSession"] = model.UserName;
                return RedirectToAction("Index", "HomeAdmin");
            }
            else
            {
                ModelState.AddModelError("", "UserName or Password not incorrect.");
            }
            return View(model);
        }

    }
}
