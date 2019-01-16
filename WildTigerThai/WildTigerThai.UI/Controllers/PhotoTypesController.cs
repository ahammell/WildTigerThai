using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WildTigerThai.DATA.EF;

namespace WildTigerThai.UI.Controllers
{
    public class PhotoTypesController : Controller
    {
        private WildTigerThaiDBEntities db = new WildTigerThaiDBEntities();

        // GET: PhotoTypes
        public ActionResult Index()
        {
            return View(db.PhotoTypes.ToList());
        }

        // GET: PhotoTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhotoType photoType = db.PhotoTypes.Find(id);
            if (photoType == null)
            {
                return HttpNotFound();
            }
            return View(photoType);
        }

        // GET: PhotoTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhotoTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Type,Active")] PhotoType photoType)
        {
            if (ModelState.IsValid)
            {
                db.PhotoTypes.Add(photoType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(photoType);
        }

        // GET: PhotoTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhotoType photoType = db.PhotoTypes.Find(id);
            if (photoType == null)
            {
                return HttpNotFound();
            }
            return View(photoType);
        }

        // POST: PhotoTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Type,Active")] PhotoType photoType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(photoType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(photoType);
        }

        // GET: PhotoTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PhotoType photoType = db.PhotoTypes.Find(id);
            if (photoType == null)
            {
                return HttpNotFound();
            }
            return View(photoType);
        }

        // POST: PhotoTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PhotoType photoType = db.PhotoTypes.Find(id);
            db.PhotoTypes.Remove(photoType);
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
