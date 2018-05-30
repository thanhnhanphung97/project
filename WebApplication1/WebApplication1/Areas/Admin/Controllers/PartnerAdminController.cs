using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using WebApplication1.Models;
using System.Net;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class PartnerAdminController : Controller
    {
        private dataEntities db = new dataEntities();

        // GET: Admin/news
        public ActionResult Index()
        {
            return View(db.partners.ToList());
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
        public ActionResult Create([Bind(Include = "id,name,img,describe,background")]partner partner)
        {
            if (ModelState.IsValid)
            {
                db.partners.Add(partner);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(partner);
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            partner partner = db.partners.Find(id);
            if (partner == null)
            {
                return HttpNotFound();
            }
            return View(partner);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            partner partner = db.partners.Find(id);
            db.partners.Remove(partner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            partner partner = db.partners.Find(id);
            if (partner == null)
            {
                return HttpNotFound();
            }
            return View(partner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(partner partner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(partner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(partner);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            partner partner = db.partners.Find(id);

            if (partner == null)
            {
                return HttpNotFound();
            }
            return View(partner);
        }

        [HttpPost, ActionName("Index")]
        [ValidateAntiForgeryToken]
        public ActionResult DetailsConfirmed(int id)
        {
            partner partner = db.partners.Find(id);
            return View(partner);
        }
    }
}