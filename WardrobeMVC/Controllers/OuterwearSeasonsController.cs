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
    public class OuterwearSeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: OuterwearSeasons
        public ActionResult Index()
        {
            return View(db.OuterwearSeasons.ToList());
        }

        // GET: OuterwearSeasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearSeason outerwearSeason = db.OuterwearSeasons.Find(id);
            if (outerwearSeason == null)
            {
                return HttpNotFound();
            }
            return View(outerwearSeason);
        }

        // GET: OuterwearSeasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OuterwearSeasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OuterwearSeasonID,OuterwearSeasonName")] OuterwearSeason outerwearSeason)
        {
            if (ModelState.IsValid)
            {
                db.OuterwearSeasons.Add(outerwearSeason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(outerwearSeason);
        }

        // GET: OuterwearSeasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearSeason outerwearSeason = db.OuterwearSeasons.Find(id);
            if (outerwearSeason == null)
            {
                return HttpNotFound();
            }
            return View(outerwearSeason);
        }

        // POST: OuterwearSeasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OuterwearSeasonID,OuterwearSeasonName")] OuterwearSeason outerwearSeason)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outerwearSeason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(outerwearSeason);
        }

        // GET: OuterwearSeasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearSeason outerwearSeason = db.OuterwearSeasons.Find(id);
            if (outerwearSeason == null)
            {
                return HttpNotFound();
            }
            return View(outerwearSeason);
        }

        // POST: OuterwearSeasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OuterwearSeason outerwearSeason = db.OuterwearSeasons.Find(id);
            db.OuterwearSeasons.Remove(outerwearSeason);
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
