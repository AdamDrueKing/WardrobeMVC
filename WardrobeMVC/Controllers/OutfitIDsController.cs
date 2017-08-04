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
    public class OutfitIDsController : Controller
    {
        private WardrobeMVCEntities db = new WardrobeMVCEntities();

        // GET: OutfitIDs
        public ActionResult Index()
        {
            var outfitIDs = db.OutfitIDs.Include(o => o.Accessory).Include(o => o.Accessories2).Include(o => o.Accessories3).Include(o => o.Accessories4).Include(o => o.Accessories5).Include(o => o.Bottom).Include(o => o.Outerwear).Include(o => o.SecondLayerTop).Include(o => o.Sho).Include(o => o.Top);
            return View(outfitIDs.ToList());
        }

        // GET: OutfitIDs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OutfitID outfitID = db.OutfitIDs.Find(id);
            if (outfitID == null)
            {
                return HttpNotFound();
            }
            return View(outfitID);
        }

        // GET: OutfitIDs/Create
        public ActionResult Create()
        {
            ViewBag.AccessoryID = new SelectList(db.Accessories, "AccessoryID", "AccessoryName");
            ViewBag.Accessory2ID = new SelectList(db.Accessories2, "Accessory2ID", "Accessory2Name");
            ViewBag.Accessory3ID = new SelectList(db.Accessories3, "Accessory3ID", "Accessory3Name");
            ViewBag.Accessory4ID = new SelectList(db.Accessories4, "Accessory4ID", "Accessory4Name");
            ViewBag.Accessory5ID = new SelectList(db.Accessories5, "Accessory5ID", "Accessory5Name");
            ViewBag.BottomID = new SelectList(db.Bottoms, "BottomID", "BottomName");
            ViewBag.OuterwearID = new SelectList(db.Outerwears, "OuterwearID", "OuterwearName");
            ViewBag.SecondLayerTopID = new SelectList(db.SecondLayerTops, "SecondLayerTopID", "SecondLayerTopName");
            ViewBag.ShoesID = new SelectList(db.Shoes, "ShoesID", "ShoeName");
            ViewBag.TopID = new SelectList(db.Tops, "TopID", "TopName");
            return View();
        }

        // POST: OutfitIDs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OutfitID1,OutfitName,TopID,SecondLayerTopID,OuterwearID,BottomID,ShoesID,AccessoryID,Accessory2ID,Accessory3ID,Accessory4ID,Accessory5ID")] OutfitID outfitID)
        {
            if (ModelState.IsValid)
            {
                db.OutfitIDs.Add(outfitID);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AccessoryID = new SelectList(db.Accessories, "AccessoryID", "AccessoryName", outfitID.AccessoryID);
            ViewBag.Accessory2ID = new SelectList(db.Accessories2, "Accessory2ID", "Accessory2Name", outfitID.Accessory2ID);
            ViewBag.Accessory3ID = new SelectList(db.Accessories3, "Accessory3ID", "Accessory3Name", outfitID.Accessory3ID);
            ViewBag.Accessory4ID = new SelectList(db.Accessories4, "Accessory4ID", "Accessory4Name", outfitID.Accessory4ID);
            ViewBag.Accessory5ID = new SelectList(db.Accessories5, "Accessory5ID", "Accessory5Name", outfitID.Accessory5ID);
            ViewBag.BottomID = new SelectList(db.Bottoms, "BottomID", "BottomName", outfitID.BottomID);
            ViewBag.OuterwearID = new SelectList(db.Outerwears, "OuterwearID", "OuterwearName", outfitID.OuterwearID);
            ViewBag.SecondLayerTopID = new SelectList(db.SecondLayerTops, "SecondLayerTopID", "SecondLayerTopName", outfitID.SecondLayerTopID);
            ViewBag.ShoesID = new SelectList(db.Shoes, "ShoesID", "ShoeName", outfitID.ShoesID);
            ViewBag.TopID = new SelectList(db.Tops, "TopID", "TopName", outfitID.TopID);
            return View(outfitID);
        }

        // GET: OutfitIDs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OutfitID outfitID = db.OutfitIDs.Find(id);
            if (outfitID == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccessoryID = new SelectList(db.Accessories, "AccessoryID", "AccessoryName", outfitID.AccessoryID);
            ViewBag.Accessory2ID = new SelectList(db.Accessories2, "Accessory2ID", "Accessory2Name", outfitID.Accessory2ID);
            ViewBag.Accessory3ID = new SelectList(db.Accessories3, "Accessory3ID", "Accessory3Name", outfitID.Accessory3ID);
            ViewBag.Accessory4ID = new SelectList(db.Accessories4, "Accessory4ID", "Accessory4Name", outfitID.Accessory4ID);
            ViewBag.Accessory5ID = new SelectList(db.Accessories5, "Accessory5ID", "Accessory5Name", outfitID.Accessory5ID);
            ViewBag.BottomID = new SelectList(db.Bottoms, "BottomID", "BottomName", outfitID.BottomID);
            ViewBag.OuterwearID = new SelectList(db.Outerwears, "OuterwearID", "OuterwearName", outfitID.OuterwearID);
            ViewBag.SecondLayerTopID = new SelectList(db.SecondLayerTops, "SecondLayerTopID", "SecondLayerTopName", outfitID.SecondLayerTopID);
            ViewBag.ShoesID = new SelectList(db.Shoes, "ShoesID", "ShoeName", outfitID.ShoesID);
            ViewBag.TopID = new SelectList(db.Tops, "TopID", "TopName", outfitID.TopID);
            return View(outfitID);
        }

        // POST: OutfitIDs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OutfitID1,OutfitName,TopID,SecondLayerTopID,OuterwearID,BottomID,ShoesID,AccessoryID,Accessory2ID,Accessory3ID,Accessory4ID,Accessory5ID")] OutfitID outfitID)
        {
            if (ModelState.IsValid)
            {
                db.Entry(outfitID).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccessoryID = new SelectList(db.Accessories, "AccessoryID", "AccessoryName", outfitID.AccessoryID);
            ViewBag.Accessory2ID = new SelectList(db.Accessories2, "Accessory2ID", "Accessory2Name", outfitID.Accessory2ID);
            ViewBag.Accessory3ID = new SelectList(db.Accessories3, "Accessory3ID", "Accessory3Name", outfitID.Accessory3ID);
            ViewBag.Accessory4ID = new SelectList(db.Accessories4, "Accessory4ID", "Accessory4Name", outfitID.Accessory4ID);
            ViewBag.Accessory5ID = new SelectList(db.Accessories5, "Accessory5ID", "Accessory5Name", outfitID.Accessory5ID);
            ViewBag.BottomID = new SelectList(db.Bottoms, "BottomID", "BottomName", outfitID.BottomID);
            ViewBag.OuterwearID = new SelectList(db.Outerwears, "OuterwearID", "OuterwearName", outfitID.OuterwearID);
            ViewBag.SecondLayerTopID = new SelectList(db.SecondLayerTops, "SecondLayerTopID", "SecondLayerTopName", outfitID.SecondLayerTopID);
            ViewBag.ShoesID = new SelectList(db.Shoes, "ShoesID", "ShoeName", outfitID.ShoesID);
            ViewBag.TopID = new SelectList(db.Tops, "TopID", "TopName", outfitID.TopID);
            return View(outfitID);
        }

        // GET: OutfitIDs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OutfitID outfitID = db.OutfitIDs.Find(id);
            if (outfitID == null)
            {
                return HttpNotFound();
            }
            return View(outfitID);
        }

        // POST: OutfitIDs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            OutfitID outfitID = db.OutfitIDs.Find(id);
            db.OutfitIDs.Remove(outfitID);
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
