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
    public class Accessory3SeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory3Seasons
        public ActionResult Index()
        {
            return View(db.Accessory3Seasons.ToList());
        }

        // GET: Accessory3Seasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Seasons accessory3Seasons = db.Accessory3Seasons.Find(id);
            if (accessory3Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Seasons);
        }

        // GET: Accessory3Seasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory3Seasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory3SeasonID,Accessory3SeasonsName")] Accessory3Seasons accessory3Seasons)
        {
            if (ModelState.IsValid)
            {
                db.Accessory3Seasons.Add(accessory3Seasons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory3Seasons);
        }

        // GET: Accessory3Seasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Seasons accessory3Seasons = db.Accessory3Seasons.Find(id);
            if (accessory3Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Seasons);
        }

        // POST: Accessory3Seasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory3SeasonID,Accessory3SeasonsName")] Accessory3Seasons accessory3Seasons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory3Seasons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory3Seasons);
        }

        // GET: Accessory3Seasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Seasons accessory3Seasons = db.Accessory3Seasons.Find(id);
            if (accessory3Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Seasons);
        }

        // POST: Accessory3Seasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory3Seasons accessory3Seasons = db.Accessory3Seasons.Find(id);
            db.Accessory3Seasons.Remove(accessory3Seasons);
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
