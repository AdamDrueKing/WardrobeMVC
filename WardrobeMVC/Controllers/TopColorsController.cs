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
    public class TopColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: TopColors
        public ActionResult Index()
        {
            return View(db.TopColors.ToList());
        }

        // GET: TopColors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopColor topColor = db.TopColors.Find(id);
            if (topColor == null)
            {
                return HttpNotFound();
            }
            return View(topColor);
        }

        // GET: TopColors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopColorID,TopColorName")] TopColor topColor)
        {
            if (ModelState.IsValid)
            {
                db.TopColors.Add(topColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(topColor);
        }

        // GET: TopColors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopColor topColor = db.TopColors.Find(id);
            if (topColor == null)
            {
                return HttpNotFound();
            }
            return View(topColor);
        }

        // POST: TopColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TopColorID,TopColorName")] TopColor topColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(topColor);
        }

        // GET: TopColors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopColor topColor = db.TopColors.Find(id);
            if (topColor == null)
            {
                return HttpNotFound();
            }
            return View(topColor);
        }

        // POST: TopColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TopColor topColor = db.TopColors.Find(id);
            db.TopColors.Remove(topColor);
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
