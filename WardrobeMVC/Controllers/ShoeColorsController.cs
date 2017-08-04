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
    public class ShoeColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: ShoeColors
        public ActionResult Index()
        {
            return View(db.ShoeColors.ToList());
        }

        // GET: ShoeColors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeColor shoeColor = db.ShoeColors.Find(id);
            if (shoeColor == null)
            {
                return HttpNotFound();
            }
            return View(shoeColor);
        }

        // GET: ShoeColors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoeColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoeColorID,ShoeColorName")] ShoeColor shoeColor)
        {
            if (ModelState.IsValid)
            {
                db.ShoeColors.Add(shoeColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(shoeColor);
        }

        // GET: ShoeColors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeColor shoeColor = db.ShoeColors.Find(id);
            if (shoeColor == null)
            {
                return HttpNotFound();
            }
            return View(shoeColor);
        }

        // POST: ShoeColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoeColorID,ShoeColorName")] ShoeColor shoeColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shoeColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(shoeColor);
        }

        // GET: ShoeColors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShoeColor shoeColor = db.ShoeColors.Find(id);
            if (shoeColor == null)
            {
                return HttpNotFound();
            }
            return View(shoeColor);
        }

        // POST: ShoeColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShoeColor shoeColor = db.ShoeColors.Find(id);
            db.ShoeColors.Remove(shoeColor);
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
