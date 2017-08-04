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
    public class Accessory3ColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory3Colors
        public ActionResult Index()
        {
            return View(db.Accessory3Colors.ToList());
        }

        // GET: Accessory3Colors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Colors accessory3Colors = db.Accessory3Colors.Find(id);
            if (accessory3Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Colors);
        }

        // GET: Accessory3Colors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory3Colors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory3ColorID,Accessory3ColorName")] Accessory3Colors accessory3Colors)
        {
            if (ModelState.IsValid)
            {
                db.Accessory3Colors.Add(accessory3Colors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory3Colors);
        }

        // GET: Accessory3Colors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Colors accessory3Colors = db.Accessory3Colors.Find(id);
            if (accessory3Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Colors);
        }

        // POST: Accessory3Colors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory3ColorID,Accessory3ColorName")] Accessory3Colors accessory3Colors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory3Colors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory3Colors);
        }

        // GET: Accessory3Colors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory3Colors accessory3Colors = db.Accessory3Colors.Find(id);
            if (accessory3Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory3Colors);
        }

        // POST: Accessory3Colors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory3Colors accessory3Colors = db.Accessory3Colors.Find(id);
            db.Accessory3Colors.Remove(accessory3Colors);
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
