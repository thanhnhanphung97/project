using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Data.Entity;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class IntroducesAdminController : Controller
    {
        private dataEntities db = new dataEntities();

        // GET: Admin/news
        public ActionResult Index()
        {
            return View(db.introduces.ToList());
        }

        // GET: Admin/news/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    news news = db.news.Find(id);
        //    if (news == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(news);
        //}

        // GET: Admin/news/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(introduce new_introduce)
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

        public ActionResult Delete(int? id)
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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            introduce introduce = db.introduces.Find(id);
            db.introduces.Remove(introduce);
            db.SaveChanges();
            return RedirectToAction("Index");
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

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsConfirmed(int id)
        {
            introduce introduce = db.introduces.Find(id);
            return View(introduce);
        }
    }
}