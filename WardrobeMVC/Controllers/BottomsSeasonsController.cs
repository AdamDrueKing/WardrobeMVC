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
    public class BottomsSeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: BottomsSeasons
        public ActionResult Index()
        {
            return View(db.BottomsSeasons.ToList());
        }

        // GET: BottomsSeasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsSeason bottomsSeason = db.BottomsSeasons.Find(id);
            if (bottomsSeason == null)
            {
                return HttpNotFound();
            }
            return View(bottomsSeason);
        }

        // GET: BottomsSeasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BottomsSeasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BottomsSeasonID,BottomsSeasonName")] BottomsSeason bottomsSeason)
        {
            if (ModelState.IsValid)
            {
                db.BottomsSeasons.Add(bottomsSeason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bottomsSeason);
        }

        // GET: BottomsSeasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsSeason bottomsSeason = db.BottomsSeasons.Find(id);
            if (bottomsSeason == null)
            {
                return HttpNotFound();
            }
            return View(bottomsSeason);
        }

        // POST: BottomsSeasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BottomsSeasonID,BottomsSeasonName")] BottomsSeason bottomsSeason)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bottomsSeason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bottomsSeason);
        }

        // GET: BottomsSeasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsSeason bottomsSeason = db.BottomsSeasons.Find(id);
            if (bottomsSeason == null)
            {
                return HttpNotFound();
            }
            return View(bottomsSeason);
        }

        // POST: BottomsSeasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BottomsSeason bottomsSeason = db.BottomsSeasons.Find(id);
            db.BottomsSeasons.Remove(bottomsSeason);
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
