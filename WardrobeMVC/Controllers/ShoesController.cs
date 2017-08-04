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
    public class ShoesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Shoes
        public ActionResult Index()
        {
            var shoes = db.Shoes.Include(s => s.ShoeColor).Include(s => s.ShoeOccasion).Include(s => s.ShoeSeason).Include(s => s.ShoeType);
            return View(shoes.ToList());
        }

        // GET: Shoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sho sho = db.Shoes.Find(id);
            if (sho == null)
            {
                return HttpNotFound();
            }
            return View(sho);
        }

        // GET: Shoes/Create
        public ActionResult Create()
        {
            ViewBag.ShoeColorID = new SelectList(db.ShoeColors, "ShoeColorID", "ShoeColorName");
            ViewBag.ShoeOccassionID = new SelectList(db.ShoeOccasions, "ShoeOccasionID", "ShoeOccassionName");
            ViewBag.ShoeSeasonID = new SelectList(db.ShoeSeasons, "ShoeSeasonID", "ShoeSeasonName");
            ViewBag.ShoeTypeID = new SelectList(db.ShoeTypes, "ShoeTypeID", "ShoeTypeName");
            return View();
        }

        // POST: Shoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoesID,ShoeName,ShoePhoto,ShoeTypeID,ShoeColorID,ShoeSeasonID,ShoeOccassionID")] Sho sho)
        {
            if (ModelState.IsValid)
            {
                db.Shoes.Add(sho);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ShoeColorID = new SelectList(db.ShoeColors, "ShoeColorID", "ShoeColorName", sho.ShoeColorID);
            ViewBag.ShoeOccassionID = new SelectList(db.ShoeOccasions, "ShoeOccasionID", "ShoeOccassionName", sho.ShoeOccassionID);
            ViewBag.ShoeSeasonID = new SelectList(db.ShoeSeasons, "ShoeSeasonID", "ShoeSeasonName", sho.ShoeSeasonID);
            ViewBag.ShoeTypeID = new SelectList(db.ShoeTypes, "ShoeTypeID", "ShoeTypeName", sho.ShoeTypeID);
            return View(sho);
        }

        // GET: Shoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sho sho = db.Shoes.Find(id);
            if (sho == null)
            {
                return HttpNotFound();
            }
            ViewBag.ShoeColorID = new SelectList(db.ShoeColors, "ShoeColorID", "ShoeColorName", sho.ShoeColorID);
            ViewBag.ShoeOccassionID = new SelectList(db.ShoeOccasions, "ShoeOccasionID", "ShoeOccassionName", sho.ShoeOccassionID);
            ViewBag.ShoeSeasonID = new SelectList(db.ShoeSeasons, "ShoeSeasonID", "ShoeSeasonName", sho.ShoeSeasonID);
            ViewBag.ShoeTypeID = new SelectList(db.ShoeTypes, "ShoeTypeID", "ShoeTypeName", sho.ShoeTypeID);
            return View(sho);
        }

        // POST: Shoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoesID,ShoeName,ShoePhoto,ShoeTypeID,ShoeColorID,ShoeSeasonID,ShoeOccassionID")] Sho sho)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sho).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ShoeColorID = new SelectList(db.ShoeColors, "ShoeColorID", "ShoeColorName", sho.ShoeColorID);
            ViewBag.ShoeOccassionID = new SelectList(db.ShoeOccasions, "ShoeOccasionID", "ShoeOccassionName", sho.ShoeOccassionID);
            ViewBag.ShoeSeasonID = new SelectList(db.ShoeSeasons, "ShoeSeasonID", "ShoeSeasonName", sho.ShoeSeasonID);
            ViewBag.ShoeTypeID = new SelectList(db.ShoeTypes, "ShoeTypeID", "ShoeTypeName", sho.ShoeTypeID);
            return View(sho);
        }

        // GET: Shoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sho sho = db.Shoes.Find(id);
            if (sho == null)
            {
                return HttpNotFound();
            }
            return View(sho);
        }

        // POST: Shoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sho sho = db.Shoes.Find(id);
            db.Shoes.Remove(sho);
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
