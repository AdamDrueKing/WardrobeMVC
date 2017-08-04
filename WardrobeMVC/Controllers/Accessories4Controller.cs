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
    public class Accessories4Controller : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessories4
        public ActionResult Index()
        {
            var accessories4 = db.Accessories4.Include(a => a.Accessory4Colors).Include(a => a.Accessory4Occassions).Include(a => a.Accessory4Seasons).Include(a => a.Accessory4Types);
            return View(accessories4.ToList());
        }

        // GET: Accessories4/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories4 accessories4 = db.Accessories4.Find(id);
            if (accessories4 == null)
            {
                return HttpNotFound();
            }
            return View(accessories4);
        }

        // GET: Accessories4/Create
        public ActionResult Create()
        {
            ViewBag.Accessory4ColorID = new SelectList(db.Accessory4Colors, "Accessory4ColorID", "Accessory4ColorName");
            ViewBag.Accessory4OccassionID = new SelectList(db.Accessory4Occassions, "Accessory4OccassionID", "Accessory4OccassionName");
            ViewBag.Accessory4SeasonID = new SelectList(db.Accessory4Seasons, "Accessory4SeasonID", "Accessory4SeasonName");
            ViewBag.Accessory4TypeID = new SelectList(db.Accessory4Types, "Accessory4TypeID", "Accessory4TypeName");
            return View();
        }

        // POST: Accessories4/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory4ID,Accessory4Name,Accessory4Photo,Accessory4TypeID,Accessory4ColorID,Accessory4SeasonID,Accessory4OccassionID")] Accessories4 accessories4)
        {
            if (ModelState.IsValid)
            {
                db.Accessories4.Add(accessories4);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Accessory4ColorID = new SelectList(db.Accessory4Colors, "Accessory4ColorID", "Accessory4ColorName", accessories4.Accessory4ColorID);
            ViewBag.Accessory4OccassionID = new SelectList(db.Accessory4Occassions, "Accessory4OccassionID", "Accessory4OccassionName", accessories4.Accessory4OccassionID);
            ViewBag.Accessory4SeasonID = new SelectList(db.Accessory4Seasons, "Accessory4SeasonID", "Accessory4SeasonName", accessories4.Accessory4SeasonID);
            ViewBag.Accessory4TypeID = new SelectList(db.Accessory4Types, "Accessory4TypeID", "Accessory4TypeName", accessories4.Accessory4TypeID);
            return View(accessories4);
        }

        // GET: Accessories4/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories4 accessories4 = db.Accessories4.Find(id);
            if (accessories4 == null)
            {
                return HttpNotFound();
            }
            ViewBag.Accessory4ColorID = new SelectList(db.Accessory4Colors, "Accessory4ColorID", "Accessory4ColorName", accessories4.Accessory4ColorID);
            ViewBag.Accessory4OccassionID = new SelectList(db.Accessory4Occassions, "Accessory4OccassionID", "Accessory4OccassionName", accessories4.Accessory4OccassionID);
            ViewBag.Accessory4SeasonID = new SelectList(db.Accessory4Seasons, "Accessory4SeasonID", "Accessory4SeasonName", accessories4.Accessory4SeasonID);
            ViewBag.Accessory4TypeID = new SelectList(db.Accessory4Types, "Accessory4TypeID", "Accessory4TypeName", accessories4.Accessory4TypeID);
            return View(accessories4);
        }

        // POST: Accessories4/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory4ID,Accessory4Name,Accessory4Photo,Accessory4TypeID,Accessory4ColorID,Accessory4SeasonID,Accessory4OccassionID")] Accessories4 accessories4)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessories4).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Accessory4ColorID = new SelectList(db.Accessory4Colors, "Accessory4ColorID", "Accessory4ColorName", accessories4.Accessory4ColorID);
            ViewBag.Accessory4OccassionID = new SelectList(db.Accessory4Occassions, "Accessory4OccassionID", "Accessory4OccassionName", accessories4.Accessory4OccassionID);
            ViewBag.Accessory4SeasonID = new SelectList(db.Accessory4Seasons, "Accessory4SeasonID", "Accessory4SeasonName", accessories4.Accessory4SeasonID);
            ViewBag.Accessory4TypeID = new SelectList(db.Accessory4Types, "Accessory4TypeID", "Accessory4TypeName", accessories4.Accessory4TypeID);
            return View(accessories4);
        }

        // GET: Accessories4/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessories4 accessories4 = db.Accessories4.Find(id);
            if (accessories4 == null)
            {
                return HttpNotFound();
            }
            return View(accessories4);
        }

        // POST: Accessories4/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessories4 accessories4 = db.Accessories4.Find(id);
            db.Accessories4.Remove(accessories4);
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
