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
    public class ShoeOccasionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: ShoeOccasions
        public ActionResult Index()
        {
            return View(db.ShoeOccasions.ToList());
        }

        // GET: ShoeOccasions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeOccasion shoeOccasion = db.ShoeOccasions.Find(id);
            if (shoeOccasion == null)
            {
                return HttpNotFound();
            }
            return View(shoeOccasion);
        }

        // GET: ShoeOccasions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoeOccasions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoeOccasionID,ShoeOccassionName")] ShoeOccasion shoeOccasion)
        {
            if (ModelState.IsValid)
            {
                db.ShoeOccasions.Add(shoeOccasion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoeOccasion);
        }

        // GET: ShoeOccasions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeOccasion shoeOccasion = db.ShoeOccasions.Find(id);
            if (shoeOccasion == null)
            {
                return HttpNotFound();
            }
            return View(shoeOccasion);
        }

        // POST: ShoeOccasions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoeOccasionID,ShoeOccassionName")] ShoeOccasion shoeOccasion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoeOccasion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoeOccasion);
        }

        // GET: ShoeOccasions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeOccasion shoeOccasion = db.ShoeOccasions.Find(id);
            if (shoeOccasion == null)
            {
                return HttpNotFound();
            }
            return View(shoeOccasion);
        }

        // POST: ShoeOccasions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShoeOccasion shoeOccasion = db.ShoeOccasions.Find(id);
            db.ShoeOccasions.Remove(shoeOccasion);
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
