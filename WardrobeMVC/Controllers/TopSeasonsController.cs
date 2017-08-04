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
    public class TopSeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: TopSeasons
        public ActionResult Index()
        {
            return View(db.TopSeasons.ToList());
        }

        // GET: TopSeasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopSeason topSeason = db.TopSeasons.Find(id);
            if (topSeason == null)
            {
                return HttpNotFound();
            }
            return View(topSeason);
        }

        // GET: TopSeasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopSeasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopSeasonID,TopSeasonName")] TopSeason topSeason)
        {
            if (ModelState.IsValid)
            {
                db.TopSeasons.Add(topSeason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(topSeason);
        }

        // GET: TopSeasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopSeason topSeason = db.TopSeasons.Find(id);
            if (topSeason == null)
            {
                return HttpNotFound();
            }
            return View(topSeason);
        }

        // POST: TopSeasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TopSeasonID,TopSeasonName")] TopSeason topSeason)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topSeason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(topSeason);
        }

        // GET: TopSeasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopSeason topSeason = db.TopSeasons.Find(id);
            if (topSeason == null)
            {
                return HttpNotFound();
            }
            return View(topSeason);
        }

        // POST: TopSeasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TopSeason topSeason = db.TopSeasons.Find(id);
            db.TopSeasons.Remove(topSeason);
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
