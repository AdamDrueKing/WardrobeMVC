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
    public class ShoeSeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: ShoeSeasons
        public ActionResult Index()
        {
            return View(db.ShoeSeasons.ToList());
        }

        // GET: ShoeSeasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeSeason shoeSeason = db.ShoeSeasons.Find(id);
            if (shoeSeason == null)
            {
                return HttpNotFound();
            }
            return View(shoeSeason);
        }

        // GET: ShoeSeasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoeSeasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoeSeasonID,ShoeSeasonName")] ShoeSeason shoeSeason)
        {
            if (ModelState.IsValid)
            {
                db.ShoeSeasons.Add(shoeSeason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoeSeason);
        }

        // GET: ShoeSeasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeSeason shoeSeason = db.ShoeSeasons.Find(id);
            if (shoeSeason == null)
            {
                return HttpNotFound();
            }
            return View(shoeSeason);
        }

        // POST: ShoeSeasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoeSeasonID,ShoeSeasonName")] ShoeSeason shoeSeason)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoeSeason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoeSeason);
        }

        // GET: ShoeSeasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeSeason shoeSeason = db.ShoeSeasons.Find(id);
            if (shoeSeason == null)
            {
                return HttpNotFound();
            }
            return View(shoeSeason);
        }

        // POST: ShoeSeasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShoeSeason shoeSeason = db.ShoeSeasons.Find(id);
            db.ShoeSeasons.Remove(shoeSeason);
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
