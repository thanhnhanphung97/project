using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class partnerController : Controller
    {
        dataEntities db = new dataEntities();
        // GET: partner
        public ActionResult Index()
        {
            return View(db.partners.ToList());
        }
    }
}