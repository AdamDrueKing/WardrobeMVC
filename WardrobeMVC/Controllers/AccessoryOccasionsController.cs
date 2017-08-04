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
    public class AccessoryOccasionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: AccessoryOccasions
        public ActionResult Index()
        {
            return View(db.AccessoryOccasions.ToList());
        }

        // GET: AccessoryOccasions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessoryOccasion accessoryOccasion = db.AccessoryOccasions.Find(id);
            if (accessoryOccasion == null)
            {
                return HttpNotFound();
            }
            return View(accessoryOccasion);
        }

        // GET: AccessoryOccasions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccessoryOccasions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccessoryOccasionID,AccessoryOccasionName")] AccessoryOccasion accessoryOccasion)
        {
            if (ModelState.IsValid)
            {
                db.AccessoryOccasions.Add(accessoryOccasion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessoryOccasion);
        }

        // GET: AccessoryOccasions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessoryOccasion accessoryOccasion = db.AccessoryOccasions.Find(id);
            if (accessoryOccasion == null)
            {
                return HttpNotFound();
            }
            return View(accessoryOccasion);
        }

        // POST: AccessoryOccasions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccessoryOccasionID,AccessoryOccasionName")] AccessoryOccasion accessoryOccasion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessoryOccasion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessoryOccasion);
        }

        // GET: AccessoryOccasions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessoryOccasion accessoryOccasion = db.AccessoryOccasions.Find(id);
            if (accessoryOccasion == null)
            {
                return HttpNotFound();
            }
            return View(accessoryOccasion);
        }

        // POST: AccessoryOccasions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccessoryOccasion accessoryOccasion = db.AccessoryOccasions.Find(id);
            db.AccessoryOccasions.Remove(accessoryOccasion);
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
