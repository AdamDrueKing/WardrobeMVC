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
    public class SecondLayerTopSeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: SecondLayerTopSeasons
        public ActionResult Index()
        {
            return View(db.SecondLayerTopSeasons.ToList());
        }

        // GET: SecondLayerTopSeasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopSeason secondLayerTopSeason = db.SecondLayerTopSeasons.Find(id);
            if (secondLayerTopSeason == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopSeason);
        }

        // GET: SecondLayerTopSeasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecondLayerTopSeasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SecondLayerTopSeasonID,SecondLayerTopSeasonName")] SecondLayerTopSeason secondLayerTopSeason)
        {
            if (ModelState.IsValid)
            {
                db.SecondLayerTopSeasons.Add(secondLayerTopSeason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(secondLayerTopSeason);
        }

        // GET: SecondLayerTopSeasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopSeason secondLayerTopSeason = db.SecondLayerTopSeasons.Find(id);
            if (secondLayerTopSeason == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopSeason);
        }

        // POST: SecondLayerTopSeasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SecondLayerTopSeasonID,SecondLayerTopSeasonName")] SecondLayerTopSeason secondLayerTopSeason)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secondLayerTopSeason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secondLayerTopSeason);
        }

        // GET: SecondLayerTopSeasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopSeason secondLayerTopSeason = db.SecondLayerTopSeasons.Find(id);
            if (secondLayerTopSeason == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopSeason);
        }

        // POST: SecondLayerTopSeasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecondLayerTopSeason secondLayerTopSeason = db.SecondLayerTopSeasons.Find(id);
            db.SecondLayerTopSeasons.Remove(secondLayerTopSeason);
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
