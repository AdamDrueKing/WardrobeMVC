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
    public class Accessory4ColorsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: Accessory4Colors
        public ActionResult Index()
        {
            return View(db.Accessory4Colors.ToList());
        }

        // GET: Accessory4Colors/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Colors accessory4Colors = db.Accessory4Colors.Find(id);
            if (accessory4Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Colors);
        }

        // GET: Accessory4Colors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Accessory4Colors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Accessory4ColorID,Accessory4ColorName")] Accessory4Colors accessory4Colors)
        {
            if (ModelState.IsValid)
            {
                db.Accessory4Colors.Add(accessory4Colors);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessory4Colors);
        }

        // GET: Accessory4Colors/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Colors accessory4Colors = db.Accessory4Colors.Find(id);
            if (accessory4Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Colors);
        }

        // POST: Accessory4Colors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Accessory4ColorID,Accessory4ColorName")] Accessory4Colors accessory4Colors)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessory4Colors).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessory4Colors);
        }

        // GET: Accessory4Colors/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Accessory4Colors accessory4Colors = db.Accessory4Colors.Find(id);
            if (accessory4Colors == null)
            {
                return HttpNotFound();
            }
            return View(accessory4Colors);
        }

        // POST: Accessory4Colors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Accessory4Colors accessory4Colors = db.Accessory4Colors.Find(id);
            db.Accessory4Colors.Remove(accessory4Colors);
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
