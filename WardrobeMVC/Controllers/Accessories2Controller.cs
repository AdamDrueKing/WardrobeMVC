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
    public class Accessories2Controller : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessories2
        public ActionResult Index()
        {
            var accessories2 = db.Accessories2.Include(a => a.Accessory2Colors).Include(a => a.Accessory2Occassions).Include(a => a.Accessory2Seasons).Include(a => a.Accessory2Types);
            return View(accessories2.ToList());
        }

        // GET: Accessories2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories2 accessories2 = db.Accessories2.Find(id);
            if (accessories2 == null)
            {
                return HttpNotFound();
            }
            return View(accessories2);
        }

        // GET: Accessories2/Create
        public ActionResult Create()
        {
            ViewBag.Accessory2ColorID = new SelectList(db.Accessory2Colors, "Accessory2ColorID", "Accessory2ColorName");
            ViewBag.Accessory2OccassionID = new SelectList(db.Accessory2Occassions, "Accessory2OccassionID", "Accessory2OccassionName");
            ViewBag.Accessory2SeasonID = new SelectList(db.Accessory2Seasons, "Accessory2SeasonID", "Accessory2SeasonName");
            ViewBag.Accessory2TypeID = new SelectList(db.Accessory2Types, "Accessory2TypeID", "Accessory2TypeName");
            return View();
        }

        // POST: Accessories2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory2ID,Accessory2Name,Accessory2Photo,Accessory2TypeID,Accessory2ColorID,Accessory2SeasonID,Accessory2OccassionID")] Accessories2 accessories2)
        {
            if (ModelState.IsValid)
            {
                db.Accessories2.Add(accessories2);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Accessory2ColorID = new SelectList(db.Accessory2Colors, "Accessory2ColorID", "Accessory2ColorName", accessories2.Accessory2ColorID);
            ViewBag.Accessory2OccassionID = new SelectList(db.Accessory2Occassions, "Accessory2OccassionID", "Accessory2OccassionName", accessories2.Accessory2OccassionID);
            ViewBag.Accessory2SeasonID = new SelectList(db.Accessory2Seasons, "Accessory2SeasonID", "Accessory2SeasonName", accessories2.Accessory2SeasonID);
            ViewBag.Accessory2TypeID = new SelectList(db.Accessory2Types, "Accessory2TypeID", "Accessory2TypeName", accessories2.Accessory2TypeID);
            return View(accessories2);
        }

        // GET: Accessories2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories2 accessories2 = db.Accessories2.Find(id);
            if (accessories2 == null)
            {
                return HttpNotFound();
            }
            ViewBag.Accessory2ColorID = new SelectList(db.Accessory2Colors, "Accessory2ColorID", "Accessory2ColorName", accessories2.Accessory2ColorID);
            ViewBag.Accessory2OccassionID = new SelectList(db.Accessory2Occassions, "Accessory2OccassionID", "Accessory2OccassionName", accessories2.Accessory2OccassionID);
            ViewBag.Accessory2SeasonID = new SelectList(db.Accessory2Seasons, "Accessory2SeasonID", "Accessory2SeasonName", accessories2.Accessory2SeasonID);
            ViewBag.Accessory2TypeID = new SelectList(db.Accessory2Types, "Accessory2TypeID", "Accessory2TypeName", accessories2.Accessory2TypeID);
            return View(accessories2);
        }

        // POST: Accessories2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory2ID,Accessory2Name,Accessory2Photo,Accessory2TypeID,Accessory2ColorID,Accessory2SeasonID,Accessory2OccassionID")] Accessories2 accessories2)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessories2).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Accessory2ColorID = new SelectList(db.Accessory2Colors, "Accessory2ColorID", "Accessory2ColorName", accessories2.Accessory2ColorID);
            ViewBag.Accessory2OccassionID = new SelectList(db.Accessory2Occassions, "Accessory2OccassionID", "Accessory2OccassionName", accessories2.Accessory2OccassionID);
            ViewBag.Accessory2SeasonID = new SelectList(db.Accessory2Seasons, "Accessory2SeasonID", "Accessory2SeasonName", accessories2.Accessory2SeasonID);
            ViewBag.Accessory2TypeID = new SelectList(db.Accessory2Types, "Accessory2TypeID", "Accessory2TypeName", accessories2.Accessory2TypeID);
            return View(accessories2);
        }

        // GET: Accessories2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories2 accessories2 = db.Accessories2.Find(id);
            if (accessories2 == null)
            {
                return HttpNotFound();
            }
            return View(accessories2);
        }

        // POST: Accessories2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessories2 accessories2 = db.Accessories2.Find(id);
            db.Accessories2.Remove(accessories2);
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
