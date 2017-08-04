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
    public class Accessory5ColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory5Colors
        public ActionResult Index()
        {
            return View(db.Accessory5Colors.ToList());
        }

        // GET: Accessory5Colors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Colors accessory5Colors = db.Accessory5Colors.Find(id);
            if (accessory5Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Colors);
        }

        // GET: Accessory5Colors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory5Colors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory5ColorID,Accessory5ColorName")] Accessory5Colors accessory5Colors)
        {
            if (ModelState.IsValid)
            {
                db.Accessory5Colors.Add(accessory5Colors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory5Colors);
        }

        // GET: Accessory5Colors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Colors accessory5Colors = db.Accessory5Colors.Find(id);
            if (accessory5Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Colors);
        }

        // POST: Accessory5Colors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory5ColorID,Accessory5ColorName")] Accessory5Colors accessory5Colors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory5Colors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory5Colors);
        }

        // GET: Accessory5Colors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory5Colors accessory5Colors = db.Accessory5Colors.Find(id);
            if (accessory5Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory5Colors);
        }

        // POST: Accessory5Colors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory5Colors accessory5Colors = db.Accessory5Colors.Find(id);
            db.Accessory5Colors.Remove(accessory5Colors);
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
