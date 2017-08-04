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
    public class Accessories5Controller : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessories5
        public ActionResult Index()
        {
            var accessories5 = db.Accessories5.Include(a => a.Accessory5Colors).Include(a => a.Accessory5Occassions).Include(a => a.Accessory5Seasons).Include(a => a.Accessory5Types);
            return View(accessories5.ToList());
        }

        // GET: Accessories5/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories5 accessories5 = db.Accessories5.Find(id);
            if (accessories5 == null)
            {
                return HttpNotFound();
            }
            return View(accessories5);
        }

        // GET: Accessories5/Create
        public ActionResult Create()
        {
            ViewBag.Accessory5ColorID = new SelectList(db.Accessory5Colors, "Accessory5ColorID", "Accessory5ColorName");
            ViewBag.Accessory5OccassionID = new SelectList(db.Accessory5Occassions, "Accessory5OccassionID", "Accessory5OccassionName");
            ViewBag.Accessory5SeasonID = new SelectList(db.Accessory5Seasons, "Accessory5SeasonID", "Accessory5SeasonName");
            ViewBag.Accessory5TypeID = new SelectList(db.Accessory5Types, "Accessory5TypeID", "Accessory5TypeName");
            return View();
        }

        // POST: Accessories5/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory5ID,Accessory5Name,Accessory5Photo,Accessory5TypeID,Accessory5ColorID,Accessory5SeasonID,Accessory5OccassionID")] Accessories5 accessories5)
        {
            if (ModelState.IsValid)
            {
                db.Accessories5.Add(accessories5);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Accessory5ColorID = new SelectList(db.Accessory5Colors, "Accessory5ColorID", "Accessory5ColorName", accessories5.Accessory5ColorID);
            ViewBag.Accessory5OccassionID = new SelectList(db.Accessory5Occassions, "Accessory5OccassionID", "Accessory5OccassionName", accessories5.Accessory5OccassionID);
            ViewBag.Accessory5SeasonID = new SelectList(db.Accessory5Seasons, "Accessory5SeasonID", "Accessory5SeasonName", accessories5.Accessory5SeasonID);
            ViewBag.Accessory5TypeID = new SelectList(db.Accessory5Types, "Accessory5TypeID", "Accessory5TypeName", accessories5.Accessory5TypeID);
            return View(accessories5);
        }

        // GET: Accessories5/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories5 accessories5 = db.Accessories5.Find(id);
            if (accessories5 == null)
            {
                return HttpNotFound();
            }
            ViewBag.Accessory5ColorID = new SelectList(db.Accessory5Colors, "Accessory5ColorID", "Accessory5ColorName", accessories5.Accessory5ColorID);
            ViewBag.Accessory5OccassionID = new SelectList(db.Accessory5Occassions, "Accessory5OccassionID", "Accessory5OccassionName", accessories5.Accessory5OccassionID);
            ViewBag.Accessory5SeasonID = new SelectList(db.Accessory5Seasons, "Accessory5SeasonID", "Accessory5SeasonName", accessories5.Accessory5SeasonID);
            ViewBag.Accessory5TypeID = new SelectList(db.Accessory5Types, "Accessory5TypeID", "Accessory5TypeName", accessories5.Accessory5TypeID);
            return View(accessories5);
        }

        // POST: Accessories5/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory5ID,Accessory5Name,Accessory5Photo,Accessory5TypeID,Accessory5ColorID,Accessory5SeasonID,Accessory5OccassionID")] Accessories5 accessories5)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessories5).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Accessory5ColorID = new SelectList(db.Accessory5Colors, "Accessory5ColorID", "Accessory5ColorName", accessories5.Accessory5ColorID);
            ViewBag.Accessory5OccassionID = new SelectList(db.Accessory5Occassions, "Accessory5OccassionID", "Accessory5OccassionName", accessories5.Accessory5OccassionID);
            ViewBag.Accessory5SeasonID = new SelectList(db.Accessory5Seasons, "Accessory5SeasonID", "Accessory5SeasonName", accessories5.Accessory5SeasonID);
            ViewBag.Accessory5TypeID = new SelectList(db.Accessory5Types, "Accessory5TypeID", "Accessory5TypeName", accessories5.Accessory5TypeID);
            return View(accessories5);
        }

        // GET: Accessories5/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories5 accessories5 = db.Accessories5.Find(id);
            if (accessories5 == null)
            {
                return HttpNotFound();
            }
            return View(accessories5);
        }

        // POST: Accessories5/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessories5 accessories5 = db.Accessories5.Find(id);
            db.Accessories5.Remove(accessories5);
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
