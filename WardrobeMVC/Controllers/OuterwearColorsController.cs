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
    public class OuterwearColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: OuterwearColors
        public ActionResult Index()
        {
            return View(db.OuterwearColors.ToList());
        }

        // GET: OuterwearColors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearColor outerwearColor = db.OuterwearColors.Find(id);
            if (outerwearColor == null)
            {
                return HttpNotFound();
            }
            return View(outerwearColor);
        }

        // GET: OuterwearColors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OuterwearColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OuterwearColorID,OuterwearColorName")] OuterwearColor outerwearColor)
        {
            if (ModelState.IsValid)
            {
                db.OuterwearColors.Add(outerwearColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(outerwearColor);
        }

        // GET: OuterwearColors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearColor outerwearColor = db.OuterwearColors.Find(id);
            if (outerwearColor == null)
            {
                return HttpNotFound();
            }
            return View(outerwearColor);
        }

        // POST: OuterwearColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OuterwearColorID,OuterwearColorName")] OuterwearColor outerwearColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outerwearColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(outerwearColor);
        }

        // GET: OuterwearColors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OuterwearColor outerwearColor = db.OuterwearColors.Find(id);
            if (outerwearColor == null)
            {
                return HttpNotFound();
            }
            return View(outerwearColor);
        }

        // POST: OuterwearColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OuterwearColor outerwearColor = db.OuterwearColors.Find(id);
            db.OuterwearColors.Remove(outerwearColor);
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
