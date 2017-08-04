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
    public class SecondLayerTopOccasionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: SecondLayerTopOccasions
        public ActionResult Index()
        {
            return View(db.SecondLayerTopOccasions.ToList());
        }

        // GET: SecondLayerTopOccasions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopOccasion secondLayerTopOccasion = db.SecondLayerTopOccasions.Find(id);
            if (secondLayerTopOccasion == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopOccasion);
        }

        // GET: SecondLayerTopOccasions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecondLayerTopOccasions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SecondLayerTopOccasionID,SecondLayerTopOccasionName")] SecondLayerTopOccasion secondLayerTopOccasion)
        {
            if (ModelState.IsValid)
            {
                db.SecondLayerTopOccasions.Add(secondLayerTopOccasion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(secondLayerTopOccasion);
        }

        // GET: SecondLayerTopOccasions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopOccasion secondLayerTopOccasion = db.SecondLayerTopOccasions.Find(id);
            if (secondLayerTopOccasion == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopOccasion);
        }

        // POST: SecondLayerTopOccasions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SecondLayerTopOccasionID,SecondLayerTopOccasionName")] SecondLayerTopOccasion secondLayerTopOccasion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secondLayerTopOccasion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secondLayerTopOccasion);
        }

        // GET: SecondLayerTopOccasions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopOccasion secondLayerTopOccasion = db.SecondLayerTopOccasions.Find(id);
            if (secondLayerTopOccasion == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopOccasion);
        }

        // POST: SecondLayerTopOccasions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecondLayerTopOccasion secondLayerTopOccasion = db.SecondLayerTopOccasions.Find(id);
            db.SecondLayerTopOccasions.Remove(secondLayerTopOccasion);
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
