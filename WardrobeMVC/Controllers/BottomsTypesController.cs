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
    public class BottomsTypesController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: BottomsTypes
        public ActionResult Index()
        {
            return View(db.BottomsTypes.ToList());
        }

        // GET: BottomsTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsType bottomsType = db.BottomsTypes.Find(id);
            if (bottomsType == null)
            {
                return HttpNotFound();
            }
            return View(bottomsType);
        }

        // GET: BottomsTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BottomsTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BottomsTypeID,BottomsTypeName")] BottomsType bottomsType)
        {
            if (ModelState.IsValid)
            {
                db.BottomsTypes.Add(bottomsType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bottomsType);
        }

        // GET: BottomsTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsType bottomsType = db.BottomsTypes.Find(id);
            if (bottomsType == null)
            {
                return HttpNotFound();
            }
            return View(bottomsType);
        }

        // POST: BottomsTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BottomsTypeID,BottomsTypeName")] BottomsType bottomsType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bottomsType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bottomsType);
        }

        // GET: BottomsTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BottomsType bottomsType = db.BottomsTypes.Find(id);
            if (bottomsType == null)
            {
                return HttpNotFound();
            }
            return View(bottomsType);
        }

        // POST: BottomsTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BottomsType bottomsType = db.BottomsTypes.Find(id);
            db.BottomsTypes.Remove(bottomsType);
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
