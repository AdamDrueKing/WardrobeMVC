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
    public class AccessorySeasonsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: AccessorySeasons
        public ActionResult Index()
        {
            return View(db.AccessorySeasons.ToList());
        }

        // GET: AccessorySeasons/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessorySeason accessorySeason = db.AccessorySeasons.Find(id);
            if (accessorySeason == null)
            {
                return HttpNotFound();
            }
            return View(accessorySeason);
        }

        // GET: AccessorySeasons/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AccessorySeasons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AccessorySeasonID,AccessorySeasonName")] AccessorySeason accessorySeason)
        {
            if (ModelState.IsValid)
            {
                db.AccessorySeasons.Add(accessorySeason);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(accessorySeason);
        }

        // GET: AccessorySeasons/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessorySeason accessorySeason = db.AccessorySeasons.Find(id);
            if (accessorySeason == null)
            {
                return HttpNotFound();
            }
            return View(accessorySeason);
        }

        // POST: AccessorySeasons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AccessorySeasonID,AccessorySeasonName")] AccessorySeason accessorySeason)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accessorySeason).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(accessorySeason);
        }

        // GET: AccessorySeasons/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AccessorySeason accessorySeason = db.AccessorySeasons.Find(id);
            if (accessorySeason == null)
            {
                return HttpNotFound();
            }
            return View(accessorySeason);
        }

        // POST: AccessorySeasons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AccessorySeason accessorySeason = db.AccessorySeasons.Find(id);
            db.AccessorySeasons.Remove(accessorySeason);
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
