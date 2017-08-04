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
    public class Accessory4OccassionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory4Occassions
        public ActionResult Index()
        {
            return View(db.Accessory4Occassions.ToList());
        }

        // GET: Accessory4Occassions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Occassions accessory4Occassions = db.Accessory4Occassions.Find(id);
            if (accessory4Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Occassions);
        }

        // GET: Accessory4Occassions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory4Occassions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory4OccassionID,Accessory4OccassionName")] Accessory4Occassions accessory4Occassions)
        {
            if (ModelState.IsValid)
            {
                db.Accessory4Occassions.Add(accessory4Occassions);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory4Occassions);
        }

        // GET: Accessory4Occassions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Occassions accessory4Occassions = db.Accessory4Occassions.Find(id);
            if (accessory4Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Occassions);
        }

        // POST: Accessory4Occassions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory4OccassionID,Accessory4OccassionName")] Accessory4Occassions accessory4Occassions)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory4Occassions).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory4Occassions);
        }

        // GET: Accessory4Occassions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Occassions accessory4Occassions = db.Accessory4Occassions.Find(id);
            if (accessory4Occassions == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Occassions);
        }

        // POST: Accessory4Occassions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory4Occassions accessory4Occassions = db.Accessory4Occassions.Find(id);
            db.Accessory4Occassions.Remove(accessory4Occassions);
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
