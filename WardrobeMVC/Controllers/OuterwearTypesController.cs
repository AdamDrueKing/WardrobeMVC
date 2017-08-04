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
    public class OuterwearTypesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: OuterwearTypes
        public ActionResult Index()
        {
            return View(db.OuterwearTypes.ToList());
        }

        // GET: OuterwearTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearType outerwearType = db.OuterwearTypes.Find(id);
            if (outerwearType == null)
            {
                return HttpNotFound();
            }
            return View(outerwearType);
        }

        // GET: OuterwearTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OuterwearTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OuterwearTypeID,OuterwearTypeName")] OuterwearType outerwearType)
        {
            if (ModelState.IsValid)
            {
                db.OuterwearTypes.Add(outerwearType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(outerwearType);
        }

        // GET: OuterwearTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearType outerwearType = db.OuterwearTypes.Find(id);
            if (outerwearType == null)
            {
                return HttpNotFound();
            }
            return View(outerwearType);
        }

        // POST: OuterwearTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OuterwearTypeID,OuterwearTypeName")] OuterwearType outerwearType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outerwearType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(outerwearType);
        }

        // GET: OuterwearTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearType outerwearType = db.OuterwearTypes.Find(id);
            if (outerwearType == null)
            {
                return HttpNotFound();
            }
            return View(outerwearType);
        }

        // POST: OuterwearTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OuterwearType outerwearType = db.OuterwearTypes.Find(id);
            db.OuterwearTypes.Remove(outerwearType);
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
