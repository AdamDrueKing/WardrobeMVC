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
    public class Accessories3Controller : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessories3
        public ActionResult Index()
        {
            var accessories3 = db.Accessories3.Include(a => a.Accessory3Types).Include(a => a.Accessory3Colors).Include(a => a.Accessory3Occassions).Include(a => a.Accessory3Seasons);
            return View(accessories3.ToList());
        }

        // GET: Accessories3/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories3 accessories3 = db.Accessories3.Find(id);
            if (accessories3 == null)
            {
                return HttpNotFound();
            }
            return View(accessories3);
        }

        // GET: Accessories3/Create
        public ActionResult Create()
        {
            ViewBag.Accessory3TypeID = new SelectList(db.Accessory3Types, "Accessory3TypeID", "Accessory3TypeName");
            ViewBag.Accessory3ColorID = new SelectList(db.Accessory3Colors, "Accessory3ColorID", "Accessory3ColorName");
            ViewBag.Accessory3OccassionID = new SelectList(db.Accessory3Occassions, "Accessory3OccassionID", "Accessory3OccassionName");
            ViewBag.Accessory3SeasonID = new SelectList(db.Accessory3Seasons, "Accessory3SeasonID", "Accessory3SeasonsName");
            return View();
        }

        // POST: Accessories3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory3ID,Accessory3Name,Accessory3Photo,Accessory3TypeID,Accessory3ColorID,Accessory3SeasonID,Accessory3OccassionID")] Accessories3 accessories3)
        {
            if (ModelState.IsValid)
            {
                db.Accessories3.Add(accessories3);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Accessory3TypeID = new SelectList(db.Accessory3Types, "Accessory3TypeID", "Accessory3TypeName", accessories3.Accessory3TypeID);
            ViewBag.Accessory3ColorID = new SelectList(db.Accessory3Colors, "Accessory3ColorID", "Accessory3ColorName", accessories3.Accessory3ColorID);
            ViewBag.Accessory3OccassionID = new SelectList(db.Accessory3Occassions, "Accessory3OccassionID", "Accessory3OccassionName", accessories3.Accessory3OccassionID);
            ViewBag.Accessory3SeasonID = new SelectList(db.Accessory3Seasons, "Accessory3SeasonID", "Accessory3SeasonsName", accessories3.Accessory3SeasonID);
            return View(accessories3);
        }

        // GET: Accessories3/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories3 accessories3 = db.Accessories3.Find(id);
            if (accessories3 == null)
            {
                return HttpNotFound();
            }
            ViewBag.Accessory3TypeID = new SelectList(db.Accessory3Types, "Accessory3TypeID", "Accessory3TypeName", accessories3.Accessory3TypeID);
            ViewBag.Accessory3ColorID = new SelectList(db.Accessory3Colors, "Accessory3ColorID", "Accessory3ColorName", accessories3.Accessory3ColorID);
            ViewBag.Accessory3OccassionID = new SelectList(db.Accessory3Occassions, "Accessory3OccassionID", "Accessory3OccassionName", accessories3.Accessory3OccassionID);
            ViewBag.Accessory3SeasonID = new SelectList(db.Accessory3Seasons, "Accessory3SeasonID", "Accessory3SeasonsName", accessories3.Accessory3SeasonID);
            return View(accessories3);
        }

        // POST: Accessories3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory3ID,Accessory3Name,Accessory3Photo,Accessory3TypeID,Accessory3ColorID,Accessory3SeasonID,Accessory3OccassionID")] Accessories3 accessories3)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessories3).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Accessory3TypeID = new SelectList(db.Accessory3Types, "Accessory3TypeID", "Accessory3TypeName", accessories3.Accessory3TypeID);
            ViewBag.Accessory3ColorID = new SelectList(db.Accessory3Colors, "Accessory3ColorID", "Accessory3ColorName", accessories3.Accessory3ColorID);
            ViewBag.Accessory3OccassionID = new SelectList(db.Accessory3Occassions, "Accessory3OccassionID", "Accessory3OccassionName", accessories3.Accessory3OccassionID);
            ViewBag.Accessory3SeasonID = new SelectList(db.Accessory3Seasons, "Accessory3SeasonID", "Accessory3SeasonsName", accessories3.Accessory3SeasonID);
            return View(accessories3);
        }

        // GET: Accessories3/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories3 accessories3 = db.Accessories3.Find(id);
            if (accessories3 == null)
            {
                return HttpNotFound();
            }
            return View(accessories3);
        }

        // POST: Accessories3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessories3 accessories3 = db.Accessories3.Find(id);
            db.Accessories3.Remove(accessories3);
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
