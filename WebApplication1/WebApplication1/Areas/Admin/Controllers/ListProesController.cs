using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Areas.Admin.Controllers
{
    public class ListProesController : Controller
    {
        private dataEntities db = new dataEntities();

        // GET: Admin/ListProes
        public ActionResult Index()
        {
            var listProes = db.ListProes.Include(l => l.Product);
            return View(listProes.ToList());
        }

        // GET: Admin/ListProes/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    ListPro listPro = db.ListProes.Find(id);
        //    if (listPro == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(listPro);
        //}

        // GET: Admin/ListProes/Create
        public ActionResult Create()
        {
            ViewBag.idList = new SelectList(db.Products, "id", "name");
            return View();
        }

        // POST: Admin/ListProes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,idList,doc")] ListPro listPro)
        {
            if (ModelState.IsValid)
            {
                db.ListProes.Add(listPro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idList = new SelectList(db.Products, "id", "name", listPro.idList);
            return View(listPro);
        }

        // GET: Admin/ListProes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListPro listPro = db.ListProes.Find(id);
            if (listPro == null)
            {
                return HttpNotFound();
            }
            ViewBag.idList = new SelectList(db.Products, "id", "name", listPro.idList);
            return View(listPro);
        }

        // POST: Admin/ListProes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,idList,doc")] ListPro listPro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(listPro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idList = new SelectList(db.Products, "id", "name", listPro.idList);
            return View(listPro);
        }

        // GET: Admin/ListProes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ListPro listPro = db.ListProes.Find(id);
            if (listPro == null)
            {
                return HttpNotFound();
            }
            return View(listPro);
        }

        // POST: Admin/ListProes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ListPro listPro = db.ListProes.Find(id);
            db.ListProes.Remove(listPro);
            db.SaveChanges();
            return RedirectToAction("Create");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
