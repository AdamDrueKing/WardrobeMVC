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
    public class Accessory5SeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory5Seasons
        public ActionResult Index()
        {
            return View(db.Accessory5Seasons.ToList());
        }

        // GET: Accessory5Seasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Seasons accessory5Seasons = db.Accessory5Seasons.Find(id);
            if (accessory5Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Seasons);
        }

        // GET: Accessory5Seasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory5Seasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory5SeasonID,Accessory5SeasonName")] Accessory5Seasons accessory5Seasons)
        {
            if (ModelState.IsValid)
            {
                db.Accessory5Seasons.Add(accessory5Seasons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory5Seasons);
        }

        // GET: Accessory5Seasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Seasons accessory5Seasons = db.Accessory5Seasons.Find(id);
            if (accessory5Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Seasons);
        }

        // POST: Accessory5Seasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory5SeasonID,Accessory5SeasonName")] Accessory5Seasons accessory5Seasons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory5Seasons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory5Seasons);
        }

        // GET: Accessory5Seasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Seasons accessory5Seasons = db.Accessory5Seasons.Find(id);
            if (accessory5Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Seasons);
        }

        // POST: Accessory5Seasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory5Seasons accessory5Seasons = db.Accessory5Seasons.Find(id);
            db.Accessory5Seasons.Remove(accessory5Seasons);
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
