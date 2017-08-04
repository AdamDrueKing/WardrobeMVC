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
    public class BottomsOccasionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: BottomsOccasions
        public ActionResult Index()
        {
            return View(db.BottomsOccasions.ToList());
        }

        // GET: BottomsOccasions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsOccasion bottomsOccasion = db.BottomsOccasions.Find(id);
            if (bottomsOccasion == null)
            {
                return HttpNotFound();
            }
            return View(bottomsOccasion);
        }

        // GET: BottomsOccasions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BottomsOccasions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BottomsOccasionID,BottomsOccasionName")] BottomsOccasion bottomsOccasion)
        {
            if (ModelState.IsValid)
            {
                db.BottomsOccasions.Add(bottomsOccasion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bottomsOccasion);
        }

        // GET: BottomsOccasions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsOccasion bottomsOccasion = db.BottomsOccasions.Find(id);
            if (bottomsOccasion == null)
            {
                return HttpNotFound();
            }
            return View(bottomsOccasion);
        }

        // POST: BottomsOccasions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BottomsOccasionID,BottomsOccasionName")] BottomsOccasion bottomsOccasion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bottomsOccasion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bottomsOccasion);
        }

        // GET: BottomsOccasions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsOccasion bottomsOccasion = db.BottomsOccasions.Find(id);
            if (bottomsOccasion == null)
            {
                return HttpNotFound();
            }
            return View(bottomsOccasion);
        }

        // POST: BottomsOccasions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BottomsOccasion bottomsOccasion = db.BottomsOccasions.Find(id);
            db.BottomsOccasions.Remove(bottomsOccasion);
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
