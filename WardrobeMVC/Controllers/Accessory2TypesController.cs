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
    public class Accessory2TypesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory2Types
        public ActionResult Index()
        {
            return View(db.Accessory2Types.ToList());
        }

        // GET: Accessory2Types/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Types accessory2Types = db.Accessory2Types.Find(id);
            if (accessory2Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Types);
        }

        // GET: Accessory2Types/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory2Types/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory2TypeID,Accessory2TypeName")] Accessory2Types accessory2Types)
        {
            if (ModelState.IsValid)
            {
                db.Accessory2Types.Add(accessory2Types);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory2Types);
        }

        // GET: Accessory2Types/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Types accessory2Types = db.Accessory2Types.Find(id);
            if (accessory2Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Types);
        }

        // POST: Accessory2Types/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory2TypeID,Accessory2TypeName")] Accessory2Types accessory2Types)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory2Types).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory2Types);
        }

        // GET: Accessory2Types/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Types accessory2Types = db.Accessory2Types.Find(id);
            if (accessory2Types == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Types);
        }

        // POST: Accessory2Types/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory2Types accessory2Types = db.Accessory2Types.Find(id);
            db.Accessory2Types.Remove(accessory2Types);
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
