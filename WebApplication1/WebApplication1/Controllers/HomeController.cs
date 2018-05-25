using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        dataEntities db = new dataEntities();
        // GET: Home
        public ActionResult Index()
        {
            var a = from i in db.introduces
                    select i;
            var b = from i in db.news
                    select i;
            View(a.ToList());
            //View(b.ToList());
            return View();
        }
        
        public ActionResult List()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(introduce new_introduce)
        {

            /*if (ModelState.IsValid)
            {
                db.AddToIntroduces(new_introduce);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(new_introduce);
            }*/
            try
            {
                if (ModelState.IsValid)
                {
                    db.introduces.Add(new_introduce);
                    db.SaveChanges();

                    return RedirectToAction("List");
                }
                else
                {
                    return View(new_introduce);
                }
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

    }
}