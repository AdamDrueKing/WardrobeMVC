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
    public class BottomsColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: BottomsColors
        public ActionResult Index()
        {
            return View(db.BottomsColors.ToList());
        }

        // GET: BottomsColors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsColor bottomsColor = db.BottomsColors.Find(id);
            if (bottomsColor == null)
            {
                return HttpNotFound();
            }
            return View(bottomsColor);
        }

        // GET: BottomsColors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BottomsColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BottomsColorID,BottomsColorName")] BottomsColor bottomsColor)
        {
            if (ModelState.IsValid)
            {
                db.BottomsColors.Add(bottomsColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bottomsColor);
        }

        // GET: BottomsColors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsColor bottomsColor = db.BottomsColors.Find(id);
            if (bottomsColor == null)
            {
                return HttpNotFound();
            }
            return View(bottomsColor);
        }

        // POST: BottomsColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BottomsColorID,BottomsColorName")] BottomsColor bottomsColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bottomsColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bottomsColor);
        }

        // GET: BottomsColors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsColor bottomsColor = db.BottomsColors.Find(id);
            if (bottomsColor == null)
            {
                return HttpNotFound();
            }
            return View(bottomsColor);
        }

        // POST: BottomsColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BottomsColor bottomsColor = db.BottomsColors.Find(id);
            db.BottomsColors.Remove(bottomsColor);
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
