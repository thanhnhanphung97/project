using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
            //var b = from i in db.news
            //        select i;
            //View(a.ToList());
            //View(b.ToList());
            return View(a.ToList());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(introduce new_introduce)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.introduces.Add(new_introduce);
                    db.SaveChanges();

                    return RedirectToAction("Index");
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

        public ActionResult Delete(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            introduce introduce = db.introduces.Find(id);
            if(introduce==null)
            {
                return HttpNotFound();
            }
            return View(introduce);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            introduce introduce = db.introduces.Find(id);
            db.introduces.Remove(introduce);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            introduce introduce = db.introduces.Find(id);

            if (introduce == null)
            {
                return HttpNotFound();
            }
            return View(introduce);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            introduce introduce = db.introduces.Find(id);
            if (introduce == null)
            {
                return HttpNotFound();
            }
            return View(introduce);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(introduce introduce)
        {
            if (ModelState.IsValid)
            {
                db.Entry(introduce).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(introduce);
        }
    }
}