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
    public class OuterwearsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Outerwears
        public ActionResult Index()
        {
            var outerwears = db.Outerwears.Include(o => o.OuterwearColor).Include(o => o.OuterwearOccassion).Include(o => o.OuterwearSeason).Include(o => o.OuterwearType);
            return View(outerwears.ToList());
        }

        // GET: Outerwears/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Outerwear outerwear = db.Outerwears.Find(id);
            if (outerwear == null)
            {
                return HttpNotFound();
            }
            return View(outerwear);
        }

        // GET: Outerwears/Create
        public ActionResult Create()
        {
            ViewBag.OuterwearColorID = new SelectList(db.OuterwearColors, "OuterwearColorID", "OuterwearColorName");
            ViewBag.OuterwearOccassionID = new SelectList(db.OuterwearOccassions, "OuterwearOccassionID", "OuterwearOccassionName");
            ViewBag.OuterwearSeasonID = new SelectList(db.OuterwearSeasons, "OuterwearSeasonID", "OuterwearSeasonName");
            ViewBag.OuterwearTypeID = new SelectList(db.OuterwearTypes, "OuterwearTypeID", "OuterwearTypeName");
            return View();
        }

        // POST: Outerwears/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OuterwearID,OuterwearName,OuterwearPhoto,OuterwearTypeID,OuterwearColorID,OuterwearSeasonID,OuterwearOccassionID")] Outerwear outerwear)
        {
            if (ModelState.IsValid)
            {
                db.Outerwears.Add(outerwear);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OuterwearColorID = new SelectList(db.OuterwearColors, "OuterwearColorID", "OuterwearColorName", outerwear.OuterwearColorID);
            ViewBag.OuterwearOccassionID = new SelectList(db.OuterwearOccassions, "OuterwearOccassionID", "OuterwearOccassionName", outerwear.OuterwearOccassionID);
            ViewBag.OuterwearSeasonID = new SelectList(db.OuterwearSeasons, "OuterwearSeasonID", "OuterwearSeasonName", outerwear.OuterwearSeasonID);
            ViewBag.OuterwearTypeID = new SelectList(db.OuterwearTypes, "OuterwearTypeID", "OuterwearTypeName", outerwear.OuterwearTypeID);
            return View(outerwear);
        }

        // GET: Outerwears/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Outerwear outerwear = db.Outerwears.Find(id);
            if (outerwear == null)
            {
                return HttpNotFound();
            }
            ViewBag.OuterwearColorID = new SelectList(db.OuterwearColors, "OuterwearColorID", "OuterwearColorName", outerwear.OuterwearColorID);
            ViewBag.OuterwearOccassionID = new SelectList(db.OuterwearOccassions, "OuterwearOccassionID", "OuterwearOccassionName", outerwear.OuterwearOccassionID);
            ViewBag.OuterwearSeasonID = new SelectList(db.OuterwearSeasons, "OuterwearSeasonID", "OuterwearSeasonName", outerwear.OuterwearSeasonID);
            ViewBag.OuterwearTypeID = new SelectList(db.OuterwearTypes, "OuterwearTypeID", "OuterwearTypeName", outerwear.OuterwearTypeID);
            return View(outerwear);
        }

        // POST: Outerwears/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OuterwearID,OuterwearName,OuterwearPhoto,OuterwearTypeID,OuterwearColorID,OuterwearSeasonID,OuterwearOccassionID")] Outerwear outerwear)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outerwear).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OuterwearColorID = new SelectList(db.OuterwearColors, "OuterwearColorID", "OuterwearColorName", outerwear.OuterwearColorID);
            ViewBag.OuterwearOccassionID = new SelectList(db.OuterwearOccassions, "OuterwearOccassionID", "OuterwearOccassionName", outerwear.OuterwearOccassionID);
            ViewBag.OuterwearSeasonID = new SelectList(db.OuterwearSeasons, "OuterwearSeasonID", "OuterwearSeasonName", outerwear.OuterwearSeasonID);
            ViewBag.OuterwearTypeID = new SelectList(db.OuterwearTypes, "OuterwearTypeID", "OuterwearTypeName", outerwear.OuterwearTypeID);
            return View(outerwear);
        }

        // GET: Outerwears/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Outerwear outerwear = db.Outerwears.Find(id);
            if (outerwear == null)
            {
                return HttpNotFound();
            }
            return View(outerwear);
        }

        // POST: Outerwears/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Outerwear outerwear = db.Outerwears.Find(id);
            db.Outerwears.Remove(outerwear);
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
