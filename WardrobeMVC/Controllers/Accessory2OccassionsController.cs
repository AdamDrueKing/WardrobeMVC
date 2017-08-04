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
    public class Accessory2OccassionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory2Occassions
        public ActionResult Index()
        {
            return View(db.Accessory2Occassions.ToList());
        }

        // GET: Accessory2Occassions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Occassions accessory2Occassions = db.Accessory2Occassions.Find(id);
            if (accessory2Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Occassions);
        }

        // GET: Accessory2Occassions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory2Occassions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory2OccassionID,Accessory2OccassionName")] Accessory2Occassions accessory2Occassions)
        {
            if (ModelState.IsValid)
            {
                db.Accessory2Occassions.Add(accessory2Occassions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory2Occassions);
        }

        // GET: Accessory2Occassions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Occassions accessory2Occassions = db.Accessory2Occassions.Find(id);
            if (accessory2Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Occassions);
        }

        // POST: Accessory2Occassions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory2OccassionID,Accessory2OccassionName")] Accessory2Occassions accessory2Occassions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory2Occassions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory2Occassions);
        }

        // GET: Accessory2Occassions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Occassions accessory2Occassions = db.Accessory2Occassions.Find(id);
            if (accessory2Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Occassions);
        }

        // POST: Accessory2Occassions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory2Occassions accessory2Occassions = db.Accessory2Occassions.Find(id);
            db.Accessory2Occassions.Remove(accessory2Occassions);
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
