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
    public class TopsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Tops
        public ActionResult Index()
        {
            var tops = db.Tops.Include(t => t.TopColor).Include(t => t.TopOccassion).Include(t => t.TopSeason).Include(t => t.TopType);
            return View(tops.ToList());
        }

        // GET: Tops/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Top top = db.Tops.Find(id);
            if (top == null)
            {
                return HttpNotFound();
            }
            return View(top);
        }

        // GET: Tops/Create
        public ActionResult Create()
        {
            ViewBag.TopColorID = new SelectList(db.TopColors, "TopColorID", "TopColorName");
            ViewBag.TopOccasionID = new SelectList(db.TopOccassions, "TopOccassionID", "TopOccassionName");
            ViewBag.TopSeasonID = new SelectList(db.TopSeasons, "TopSeasonID", "TopSeasonName");
            ViewBag.TopTypeID = new SelectList(db.TopTypes, "TopTypeID", "TopTypeName");
            return View();
        }

        // POST: Tops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopID,TopName,TopPhoto,TopTypeID,TopColorID,TopSeasonID,TopOccasionID")] Top top)
        {
            if (ModelState.IsValid)
            {
                db.Tops.Add(top);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TopColorID = new SelectList(db.TopColors, "TopColorID", "TopColorName", top.TopColorID);
            ViewBag.TopOccasionID = new SelectList(db.TopOccassions, "TopOccassionID", "TopOccassionName", top.TopOccasionID);
            ViewBag.TopSeasonID = new SelectList(db.TopSeasons, "TopSeasonID", "TopSeasonName", top.TopSeasonID);
            ViewBag.TopTypeID = new SelectList(db.TopTypes, "TopTypeID", "TopTypeName", top.TopTypeID);
            return View(top);
        }

        // GET: Tops/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Top top = db.Tops.Find(id);
            if (top == null)
            {
                return HttpNotFound();
            }
            ViewBag.TopColorID = new SelectList(db.TopColors, "TopColorID", "TopColorName", top.TopColorID);
            ViewBag.TopOccasionID = new SelectList(db.TopOccassions, "TopOccassionID", "TopOccassionName", top.TopOccasionID);
            ViewBag.TopSeasonID = new SelectList(db.TopSeasons, "TopSeasonID", "TopSeasonName", top.TopSeasonID);
            ViewBag.TopTypeID = new SelectList(db.TopTypes, "TopTypeID", "TopTypeName", top.TopTypeID);
            return View(top);
        }

        // POST: Tops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TopID,TopName,TopPhoto,TopTypeID,TopColorID,TopSeasonID,TopOccasionID")] Top top)
        {
            if (ModelState.IsValid)
            {
                db.Entry(top).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TopColorID = new SelectList(db.TopColors, "TopColorID", "TopColorName", top.TopColorID);
            ViewBag.TopOccasionID = new SelectList(db.TopOccassions, "TopOccassionID", "TopOccassionName", top.TopOccasionID);
            ViewBag.TopSeasonID = new SelectList(db.TopSeasons, "TopSeasonID", "TopSeasonName", top.TopSeasonID);
            ViewBag.TopTypeID = new SelectList(db.TopTypes, "TopTypeID", "TopTypeName", top.TopTypeID);
            return View(top);
        }

        // GET: Tops/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Top top = db.Tops.Find(id);
            if (top == null)
            {
                return HttpNotFound();
            }
            return View(top);
        }

        // POST: Tops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Top top = db.Tops.Find(id);
            db.Tops.Remove(top);
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
