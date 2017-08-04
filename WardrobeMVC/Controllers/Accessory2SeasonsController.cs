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
    public class Accessory2SeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory2Seasons
        public ActionResult Index()
        {
            return View(db.Accessory2Seasons.ToList());
        }

        // GET: Accessory2Seasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Seasons accessory2Seasons = db.Accessory2Seasons.Find(id);
            if (accessory2Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Seasons);
        }

        // GET: Accessory2Seasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory2Seasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory2SeasonID,Accessory2SeasonName")] Accessory2Seasons accessory2Seasons)
        {
            if (ModelState.IsValid)
            {
                db.Accessory2Seasons.Add(accessory2Seasons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory2Seasons);
        }

        // GET: Accessory2Seasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Seasons accessory2Seasons = db.Accessory2Seasons.Find(id);
            if (accessory2Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Seasons);
        }

        // POST: Accessory2Seasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory2SeasonID,Accessory2SeasonName")] Accessory2Seasons accessory2Seasons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory2Seasons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory2Seasons);
        }

        // GET: Accessory2Seasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Seasons accessory2Seasons = db.Accessory2Seasons.Find(id);
            if (accessory2Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Seasons);
        }

        // POST: Accessory2Seasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory2Seasons accessory2Seasons = db.Accessory2Seasons.Find(id);
            db.Accessory2Seasons.Remove(accessory2Seasons);
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
