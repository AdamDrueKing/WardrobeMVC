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
    public class Accessory5TypesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory5Types
        public ActionResult Index()
        {
            return View(db.Accessory5Types.ToList());
        }

        // GET: Accessory5Types/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Types accessory5Types = db.Accessory5Types.Find(id);
            if (accessory5Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Types);
        }

        // GET: Accessory5Types/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory5Types/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory5TypeID,Accessory5TypeName")] Accessory5Types accessory5Types)
        {
            if (ModelState.IsValid)
            {
                db.Accessory5Types.Add(accessory5Types);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory5Types);
        }

        // GET: Accessory5Types/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Types accessory5Types = db.Accessory5Types.Find(id);
            if (accessory5Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Types);
        }

        // POST: Accessory5Types/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory5TypeID,Accessory5TypeName")] Accessory5Types accessory5Types)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory5Types).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory5Types);
        }

        // GET: Accessory5Types/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Types accessory5Types = db.Accessory5Types.Find(id);
            if (accessory5Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Types);
        }

        // POST: Accessory5Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory5Types accessory5Types = db.Accessory5Types.Find(id);
            db.Accessory5Types.Remove(accessory5Types);
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
