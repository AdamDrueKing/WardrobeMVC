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
    public class TopOccassionsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: TopOccassions
        public ActionResult Index()
        {
            return View(db.TopOccassions.ToList());
        }

        // GET: TopOccassions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopOccassion topOccassion = db.TopOccassions.Find(id);
            if (topOccassion == null)
            {
                return HttpNotFound();
            }
            return View(topOccassion);
        }

        // GET: TopOccassions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TopOccassions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TopOccassionID,TopOccassionName")] TopOccassion topOccassion)
        {
            if (ModelState.IsValid)
            {
                db.TopOccassions.Add(topOccassion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(topOccassion);
        }

        // GET: TopOccassions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopOccassion topOccassion = db.TopOccassions.Find(id);
            if (topOccassion == null)
            {
                return HttpNotFound();
            }
            return View(topOccassion);
        }

        // POST: TopOccassions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TopOccassionID,TopOccassionName")] TopOccassion topOccassion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(topOccassion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(topOccassion);
        }

        // GET: TopOccassions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TopOccassion topOccassion = db.TopOccassions.Find(id);
            if (topOccassion == null)
            {
                return HttpNotFound();
            }
            return View(topOccassion);
        }

        // POST: TopOccassions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TopOccassion topOccassion = db.TopOccassions.Find(id);
            db.TopOccassions.Remove(topOccassion);
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
