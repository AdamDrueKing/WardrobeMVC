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
    public class SecondLayerTopTypesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: SecondLayerTopTypes
        public ActionResult Index()
        {
            return View(db.SecondLayerTopTypes.ToList());
        }

        // GET: SecondLayerTopTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopType secondLayerTopType = db.SecondLayerTopTypes.Find(id);
            if (secondLayerTopType == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopType);
        }

        // GET: SecondLayerTopTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SecondLayerTopTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SecondLayerTopTypeID,SecondLayerTopName")] SecondLayerTopType secondLayerTopType)
        {
            if (ModelState.IsValid)
            {
                db.SecondLayerTopTypes.Add(secondLayerTopType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(secondLayerTopType);
        }

        // GET: SecondLayerTopTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopType secondLayerTopType = db.SecondLayerTopTypes.Find(id);
            if (secondLayerTopType == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopType);
        }

        // POST: SecondLayerTopTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SecondLayerTopTypeID,SecondLayerTopName")] SecondLayerTopType secondLayerTopType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(secondLayerTopType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(secondLayerTopType);
        }

        // GET: SecondLayerTopTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SecondLayerTopType secondLayerTopType = db.SecondLayerTopTypes.Find(id);
            if (secondLayerTopType == null)
            {
                return HttpNotFound();
            }
            return View(secondLayerTopType);
        }

        // POST: SecondLayerTopTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SecondLayerTopType secondLayerTopType = db.SecondLayerTopTypes.Find(id);
            db.SecondLayerTopTypes.Remove(secondLayerTopType);
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
