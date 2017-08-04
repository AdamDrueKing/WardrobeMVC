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
    public class Accessory4SeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory4Seasons
        public ActionResult Index()
        {
            return View(db.Accessory4Seasons.ToList());
        }

        // GET: Accessory4Seasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Seasons accessory4Seasons = db.Accessory4Seasons.Find(id);
            if (accessory4Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Seasons);
        }

        // GET: Accessory4Seasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory4Seasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory4SeasonID,Accessory4SeasonName")] Accessory4Seasons accessory4Seasons)
        {
            if (ModelState.IsValid)
            {
                db.Accessory4Seasons.Add(accessory4Seasons);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory4Seasons);
        }

        // GET: Accessory4Seasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Seasons accessory4Seasons = db.Accessory4Seasons.Find(id);
            if (accessory4Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Seasons);
        }

        // POST: Accessory4Seasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory4SeasonID,Accessory4SeasonName")] Accessory4Seasons accessory4Seasons)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory4Seasons).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory4Seasons);
        }

        // GET: Accessory4Seasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Seasons accessory4Seasons = db.Accessory4Seasons.Find(id);
            if (accessory4Seasons == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Seasons);
        }

        // POST: Accessory4Seasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory4Seasons accessory4Seasons = db.Accessory4Seasons.Find(id);
            db.Accessory4Seasons.Remove(accessory4Seasons);
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
