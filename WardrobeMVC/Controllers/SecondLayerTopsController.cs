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
    public class SecondLayerTopsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: SecondLayerTops
        public ActionResult Index()
        {
            var secondLayerTops = db.SecondLayerTops.Include(s => s.SecondLayerTopColor).Include(s => s.SecondLayerTopOccasion).Include(s => s.SecondLayerTopSeason).Include(s => s.SecondLayerTopType);
            return View(secondLayerTops.ToList());
        }

        // GET: SecondLayerTops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTop secondLayerTop = db.SecondLayerTops.Find(id);
            if (secondLayerTop == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTop);
        }

        // GET: SecondLayerTops/Create
        public ActionResult Create()
        {
            ViewBag.SecondLayerTopColorID = new SelectList(db.SecondLayerTopColors, "SecondLayerTopColorID", "SecondLayerTopColorName");
            ViewBag.SecondLayerTopOccassionID = new SelectList(db.SecondLayerTopOccasions, "SecondLayerTopOccasionID", "SecondLayerTopOccasionName");
            ViewBag.SecondLayerTopSeasonID = new SelectList(db.SecondLayerTopSeasons, "SecondLayerTopSeasonID", "SecondLayerTopSeasonName");
            ViewBag.SecondLayerTopTypeID = new SelectList(db.SecondLayerTopTypes, "SecondLayerTopTypeID", "SecondLayerTopName");
            return View();
        }

        // POST: SecondLayerTops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SecondLayerTopID,SecondLayerTopName,SecondLayerTopPhoto,SecondLayerTopTypeID,SecondLayerTopColorID,SecondLayerTopSeasonID,SecondLayerTopOccassionID")] SecondLayerTop secondLayerTop)
        {
            if (ModelState.IsValid)
            {
                db.SecondLayerTops.Add(secondLayerTop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SecondLayerTopColorID = new SelectList(db.SecondLayerTopColors, "SecondLayerTopColorID", "SecondLayerTopColorName", secondLayerTop.SecondLayerTopColorID);
            ViewBag.SecondLayerTopOccassionID = new SelectList(db.SecondLayerTopOccasions, "SecondLayerTopOccasionID", "SecondLayerTopOccasionName", secondLayerTop.SecondLayerTopOccassionID);
            ViewBag.SecondLayerTopSeasonID = new SelectList(db.SecondLayerTopSeasons, "SecondLayerTopSeasonID", "SecondLayerTopSeasonName", secondLayerTop.SecondLayerTopSeasonID);
            ViewBag.SecondLayerTopTypeID = new SelectList(db.SecondLayerTopTypes, "SecondLayerTopTypeID", "SecondLayerTopName", secondLayerTop.SecondLayerTopTypeID);
            return View(secondLayerTop);
        }

        // GET: SecondLayerTops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTop secondLayerTop = db.SecondLayerTops.Find(id);
            if (secondLayerTop == null)
            {
                return HttpNotFound();
            }
            ViewBag.SecondLayerTopColorID = new SelectList(db.SecondLayerTopColors, "SecondLayerTopColorID", "SecondLayerTopColorName", secondLayerTop.SecondLayerTopColorID);
            ViewBag.SecondLayerTopOccassionID = new SelectList(db.SecondLayerTopOccasions, "SecondLayerTopOccasionID", "SecondLayerTopOccasionName", secondLayerTop.SecondLayerTopOccassionID);
            ViewBag.SecondLayerTopSeasonID = new SelectList(db.SecondLayerTopSeasons, "SecondLayerTopSeasonID", "SecondLayerTopSeasonName", secondLayerTop.SecondLayerTopSeasonID);
            ViewBag.SecondLayerTopTypeID = new SelectList(db.SecondLayerTopTypes, "SecondLayerTopTypeID", "SecondLayerTopName", secondLayerTop.SecondLayerTopTypeID);
            return View(secondLayerTop);
        }

        // POST: SecondLayerTops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SecondLayerTopID,SecondLayerTopName,SecondLayerTopPhoto,SecondLayerTopTypeID,SecondLayerTopColorID,SecondLayerTopSeasonID,SecondLayerTopOccassionID")] SecondLayerTop secondLayerTop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secondLayerTop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SecondLayerTopColorID = new SelectList(db.SecondLayerTopColors, "SecondLayerTopColorID", "SecondLayerTopColorName", secondLayerTop.SecondLayerTopColorID);
            ViewBag.SecondLayerTopOccassionID = new SelectList(db.SecondLayerTopOccasions, "SecondLayerTopOccasionID", "SecondLayerTopOccasionName", secondLayerTop.SecondLayerTopOccassionID);
            ViewBag.SecondLayerTopSeasonID = new SelectList(db.SecondLayerTopSeasons, "SecondLayerTopSeasonID", "SecondLayerTopSeasonName", secondLayerTop.SecondLayerTopSeasonID);
            ViewBag.SecondLayerTopTypeID = new SelectList(db.SecondLayerTopTypes, "SecondLayerTopTypeID", "SecondLayerTopName", secondLayerTop.SecondLayerTopTypeID);
            return View(secondLayerTop);
        }

        // GET: SecondLayerTops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTop secondLayerTop = db.SecondLayerTops.Find(id);
            if (secondLayerTop == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTop);
        }

        // POST: SecondLayerTops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecondLayerTop secondLayerTop = db.SecondLayerTops.Find(id);
            db.SecondLayerTops.Remove(secondLayerTop);
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
