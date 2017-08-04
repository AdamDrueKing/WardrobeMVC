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
    public class Accessory5OccassionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory5Occassions
        public ActionResult Index()
        {
            return View(db.Accessory5Occassions.ToList());
        }

        // GET: Accessory5Occassions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Occassions accessory5Occassions = db.Accessory5Occassions.Find(id);
            if (accessory5Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Occassions);
        }

        // GET: Accessory5Occassions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory5Occassions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory5OccassionID,Accessory5OccassionName")] Accessory5Occassions accessory5Occassions)
        {
            if (ModelState.IsValid)
            {
                db.Accessory5Occassions.Add(accessory5Occassions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory5Occassions);
        }

        // GET: Accessory5Occassions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Occassions accessory5Occassions = db.Accessory5Occassions.Find(id);
            if (accessory5Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Occassions);
        }

        // POST: Accessory5Occassions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory5OccassionID,Accessory5OccassionName")] Accessory5Occassions accessory5Occassions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory5Occassions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory5Occassions);
        }

        // GET: Accessory5Occassions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Occassions accessory5Occassions = db.Accessory5Occassions.Find(id);
            if (accessory5Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Occassions);
        }

        // POST: Accessory5Occassions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory5Occassions accessory5Occassions = db.Accessory5Occassions.Find(id);
            db.Accessory5Occassions.Remove(accessory5Occassions);
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
