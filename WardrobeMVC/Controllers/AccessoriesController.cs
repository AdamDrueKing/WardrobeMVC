﻿using System;
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
    public class AccessoriesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessories
        public ActionResult Index()
        {
            var accessories = db.Accessories.Include(a => a.AccessoryColor).Include(a => a.AccessoryOccasion).Include(a => a.AccessorySeason).Include(a => a.AccessoryType);
            return View(accessories.ToList());
        }

        // GET: Accessories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory accessory = db.Accessories.Find(id);
            if (accessory == null)
            {
                return HttpNotFound();
            }
            return View(accessory);
        }

        // GET: Accessories/Create
        public ActionResult Create()
        {
            ViewBag.AccessoryColorID = new SelectList(db.AccessoryColors, "AccessoryColorID", "AccessoryColorName");
            ViewBag.AccessoryOccassionID = new SelectList(db.AccessoryOccasions, "AccessoryOccasionID", "AccessoryOccasionName");
            ViewBag.AccessorySeasonID = new SelectList(db.AccessorySeasons, "AccessorySeasonID", "AccessorySeasonName");
            ViewBag.AccessoryTypeID = new SelectList(db.AccessoryTypes, "AccessoryTypeID", "AccessoryTypeName");
            return View();
        }

        // POST: Accessories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccessoryID,AccessoryName,AccessoryPhoto,AccessoryTypeID,AccessoryColorID,AccessorySeasonID,AccessoryOccassionID")] Accessory accessory)
        {
            if (ModelState.IsValid)
            {
                db.Accessories.Add(accessory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AccessoryColorID = new SelectList(db.AccessoryColors, "AccessoryColorID", "AccessoryColorName", accessory.AccessoryColorID);
            ViewBag.AccessoryOccassionID = new SelectList(db.AccessoryOccasions, "AccessoryOccasionID", "AccessoryOccasionName", accessory.AccessoryOccassionID);
            ViewBag.AccessorySeasonID = new SelectList(db.AccessorySeasons, "AccessorySeasonID", "AccessorySeasonName", accessory.AccessorySeasonID);
            ViewBag.AccessoryTypeID = new SelectList(db.AccessoryTypes, "AccessoryTypeID", "AccessoryTypeName", accessory.AccessoryTypeID);
            return View(accessory);
        }

        // GET: Accessories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory accessory = db.Accessories.Find(id);
            if (accessory == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccessoryColorID = new SelectList(db.AccessoryColors, "AccessoryColorID", "AccessoryColorName", accessory.AccessoryColorID);
            ViewBag.AccessoryOccassionID = new SelectList(db.AccessoryOccasions, "AccessoryOccasionID", "AccessoryOccasionName", accessory.AccessoryOccassionID);
            ViewBag.AccessorySeasonID = new SelectList(db.AccessorySeasons, "AccessorySeasonID", "AccessorySeasonName", accessory.AccessorySeasonID);
            ViewBag.AccessoryTypeID = new SelectList(db.AccessoryTypes, "AccessoryTypeID", "AccessoryTypeName", accessory.AccessoryTypeID);
            return View(accessory);
        }

        // POST: Accessories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccessoryID,AccessoryName,AccessoryPhoto,AccessoryTypeID,AccessoryColorID,AccessorySeasonID,AccessoryOccassionID")] Accessory accessory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccessoryColorID = new SelectList(db.AccessoryColors, "AccessoryColorID", "AccessoryColorName", accessory.AccessoryColorID);
            ViewBag.AccessoryOccassionID = new SelectList(db.AccessoryOccasions, "AccessoryOccasionID", "AccessoryOccasionName", accessory.AccessoryOccassionID);
            ViewBag.AccessorySeasonID = new SelectList(db.AccessorySeasons, "AccessorySeasonID", "AccessorySeasonName", accessory.AccessorySeasonID);
            ViewBag.AccessoryTypeID = new SelectList(db.AccessoryTypes, "AccessoryTypeID", "AccessoryTypeName", accessory.AccessoryTypeID);
            return View(accessory);
        }

        // GET: Accessories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory accessory = db.Accessories.Find(id);
            if (accessory == null)
            {
                return HttpNotFound();
            }
            return View(accessory);
        }

        // POST: Accessories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory accessory = db.Accessories.Find(id);
            db.Accessories.Remove(accessory);
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
