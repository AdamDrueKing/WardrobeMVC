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
    public class Accessory3OccassionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory3Occassions
        public ActionResult Index()
        {
            return View(db.Accessory3Occassions.ToList());
        }

        // GET: Accessory3Occassions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Occassions accessory3Occassions = db.Accessory3Occassions.Find(id);
            if (accessory3Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Occassions);
        }

        // GET: Accessory3Occassions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory3Occassions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory3OccassionID,Accessory3OccassionName")] Accessory3Occassions accessory3Occassions)
        {
            if (ModelState.IsValid)
            {
                db.Accessory3Occassions.Add(accessory3Occassions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory3Occassions);
        }

        // GET: Accessory3Occassions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Occassions accessory3Occassions = db.Accessory3Occassions.Find(id);
            if (accessory3Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Occassions);
        }

        // POST: Accessory3Occassions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory3OccassionID,Accessory3OccassionName")] Accessory3Occassions accessory3Occassions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory3Occassions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory3Occassions);
        }

        // GET: Accessory3Occassions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Occassions accessory3Occassions = db.Accessory3Occassions.Find(id);
            if (accessory3Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Occassions);
        }

        // POST: Accessory3Occassions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory3Occassions accessory3Occassions = db.Accessory3Occassions.Find(id);
            db.Accessory3Occassions.Remove(accessory3Occassions);
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
