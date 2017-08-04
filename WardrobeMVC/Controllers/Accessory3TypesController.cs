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
    public class Accessory3TypesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory3Types
        public ActionResult Index()
        {
            return View(db.Accessory3Types.ToList());
        }

        // GET: Accessory3Types/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Types accessory3Types = db.Accessory3Types.Find(id);
            if (accessory3Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Types);
        }

        // GET: Accessory3Types/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory3Types/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory3TypeID,Accessory3TypeName")] Accessory3Types accessory3Types)
        {
            if (ModelState.IsValid)
            {
                db.Accessory3Types.Add(accessory3Types);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory3Types);
        }

        // GET: Accessory3Types/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Types accessory3Types = db.Accessory3Types.Find(id);
            if (accessory3Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Types);
        }

        // POST: Accessory3Types/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory3TypeID,Accessory3TypeName")] Accessory3Types accessory3Types)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory3Types).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory3Types);
        }

        // GET: Accessory3Types/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Types accessory3Types = db.Accessory3Types.Find(id);
            if (accessory3Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Types);
        }

        // POST: Accessory3Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory3Types accessory3Types = db.Accessory3Types.Find(id);
            db.Accessory3Types.Remove(accessory3Types);
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
