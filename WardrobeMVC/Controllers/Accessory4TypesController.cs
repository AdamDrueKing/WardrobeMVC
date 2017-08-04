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
    public class Accessory4TypesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory4Types
        public ActionResult Index()
        {
            return View(db.Accessory4Types.ToList());
        }

        // GET: Accessory4Types/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Types accessory4Types = db.Accessory4Types.Find(id);
            if (accessory4Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Types);
        }

        // GET: Accessory4Types/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory4Types/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory4TypeID,Accessory4TypeName")] Accessory4Types accessory4Types)
        {
            if (ModelState.IsValid)
            {
                db.Accessory4Types.Add(accessory4Types);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory4Types);
        }

        // GET: Accessory4Types/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Types accessory4Types = db.Accessory4Types.Find(id);
            if (accessory4Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Types);
        }

        // POST: Accessory4Types/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory4TypeID,Accessory4TypeName")] Accessory4Types accessory4Types)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory4Types).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory4Types);
        }

        // GET: Accessory4Types/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Types accessory4Types = db.Accessory4Types.Find(id);
            if (accessory4Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Types);
        }

        // POST: Accessory4Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory4Types accessory4Types = db.Accessory4Types.Find(id);
            db.Accessory4Types.Remove(accessory4Types);
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
