using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WardrobeMVC.Models;

namespace WardrobeMVC.Controllers
{
    public class OuterwearOccassionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: OuterwearOccassions
        public ActionResult Index()
        {
            return View(db.OuterwearOccassions.ToList());
        }

        // GET: OuterwearOccassions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearOccassion outerwearOccassion = db.OuterwearOccassions.Find(id);
            if (outerwearOccassion == null)
            {
                return HttpNotFound();
            }
            return View(outerwearOccassion);
        }

        // GET: OuterwearOccassions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OuterwearOccassions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OuterwearOccassionID,OuterwearOccassionName")] OuterwearOccassion outerwearOccassion)
        {
            if (ModelState.IsValid)
            {
                db.OuterwearOccassions.Add(outerwearOccassion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(outerwearOccassion);
        }

        // GET: OuterwearOccassions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearOccassion outerwearOccassion = db.OuterwearOccassions.Find(id);
            if (outerwearOccassion == null)
            {
                return HttpNotFound();
            }
            return View(outerwearOccassion);
        }

        // POST: OuterwearOccassions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OuterwearOccassionID,OuterwearOccassionName")] OuterwearOccassion outerwearOccassion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outerwearOccassion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(outerwearOccassion);
        }

        // GET: OuterwearOccassions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearOccassion outerwearOccassion = db.OuterwearOccassions.Find(id);
            if (outerwearOccassion == null)
            {
                return HttpNotFound();
            }
            return View(outerwearOccassion);
        }

        // POST: OuterwearOccassions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OuterwearOccassion outerwearOccassion = db.OuterwearOccassions.Find(id);
            db.OuterwearOccassions.Remove(outerwearOccassion);
            db.SaveChanges();
            return RedirectToAction("Index");
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
