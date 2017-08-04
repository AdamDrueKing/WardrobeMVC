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
    public class AccessoryColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: AccessoryColors
        public ActionResult Index()
        {
            return View(db.AccessoryColors.ToList());
        }

        // GET: AccessoryColors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessoryColor accessoryColor = db.AccessoryColors.Find(id);
            if (accessoryColor == null)
            {
                return HttpNotFound();
            }
            return View(accessoryColor);
        }

        // GET: AccessoryColors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccessoryColors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccessoryColorID,AccessoryColorName")] AccessoryColor accessoryColor)
        {
            if (ModelState.IsValid)
            {
                db.AccessoryColors.Add(accessoryColor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessoryColor);
        }

        // GET: AccessoryColors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessoryColor accessoryColor = db.AccessoryColors.Find(id);
            if (accessoryColor == null)
            {
                return HttpNotFound();
            }
            return View(accessoryColor);
        }

        // POST: AccessoryColors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccessoryColorID,AccessoryColorName")] AccessoryColor accessoryColor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessoryColor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessoryColor);
        }

        // GET: AccessoryColors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessoryColor accessoryColor = db.AccessoryColors.Find(id);
            if (accessoryColor == null)
            {
                return HttpNotFound();
            }
            return View(accessoryColor);
        }

        // POST: AccessoryColors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccessoryColor accessoryColor = db.AccessoryColors.Find(id);
            db.AccessoryColors.Remove(accessoryColor);
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
