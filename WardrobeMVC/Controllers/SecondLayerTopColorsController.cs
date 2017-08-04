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
    public class SecondLayerTopColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: SecondLayerTopColors
        public ActionResult Index()
        {
            return View(db.SecondLayerTopColors.ToList());
        }

        // GET: SecondLayerTopColors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopColor secondLayerTopColor = db.SecondLayerTopColors.Find(id);
            if (secondLayerTopColor == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopColor);
        }

        // GET: SecondLayerTopColors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecondLayerTopColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SecondLayerTopColorID,SecondLayerTopColorName")] SecondLayerTopColor secondLayerTopColor)
        {
            if (ModelState.IsValid)
            {
                db.SecondLayerTopColors.Add(secondLayerTopColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(secondLayerTopColor);
        }

        // GET: SecondLayerTopColors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopColor secondLayerTopColor = db.SecondLayerTopColors.Find(id);
            if (secondLayerTopColor == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopColor);
        }

        // POST: SecondLayerTopColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SecondLayerTopColorID,SecondLayerTopColorName")] SecondLayerTopColor secondLayerTopColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secondLayerTopColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secondLayerTopColor);
        }

        // GET: SecondLayerTopColors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopColor secondLayerTopColor = db.SecondLayerTopColors.Find(id);
            if (secondLayerTopColor == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopColor);
        }

        // POST: SecondLayerTopColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecondLayerTopColor secondLayerTopColor = db.SecondLayerTopColors.Find(id);
            db.SecondLayerTopColors.Remove(secondLayerTopColor);
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
