using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        dataEntities db = new dataEntities();
        // GET: Product
        public ActionResult Index()
        {
            var a = from i in db.Products
                    select i;
            return View(a.ToList());
        }
        
    }
}