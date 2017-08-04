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
    public class Accessory2ColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory2Colors
        public ActionResult Index()
        {
            return View(db.Accessory2Colors.ToList());
        }

        // GET: Accessory2Colors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Colors accessory2Colors = db.Accessory2Colors.Find(id);
            if (accessory2Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Colors);
        }

        // GET: Accessory2Colors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory2Colors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory2ColorID,Accessory2ColorName")] Accessory2Colors accessory2Colors)
        {
            if (ModelState.IsValid)
            {
                db.Accessory2Colors.Add(accessory2Colors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory2Colors);
        }

        // GET: Accessory2Colors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Colors accessory2Colors = db.Accessory2Colors.Find(id);
            if (accessory2Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Colors);
        }

        // POST: Accessory2Colors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory2ColorID,Accessory2ColorName")] Accessory2Colors accessory2Colors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory2Colors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory2Colors);
        }

        // GET: Accessory2Colors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory2Colors accessory2Colors = db.Accessory2Colors.Find(id);
            if (accessory2Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory2Colors);
        }

        // POST: Accessory2Colors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory2Colors accessory2Colors = db.Accessory2Colors.Find(id);
            db.Accessory2Colors.Remove(accessory2Colors);
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
