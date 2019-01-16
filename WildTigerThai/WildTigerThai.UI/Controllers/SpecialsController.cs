﻿using System;
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
    public class SpecialsController : Controller
    {
        private WildTigerThaiDBEntities db = new WildTigerThaiDBEntities();

        // GET: Specials
        public ActionResult Index()
        {
            return View(db.Specials.ToList());
        }

        // GET: Specials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Special special = db.Specials.Find(id);
            if (special == null)
            {
                return HttpNotFound();
            }
            return View(special);
        }

        // GET: Specials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Specials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,SpecialBeginningDate,SpecialEndDate,SpecialStartTime,SpecialEndTime,Active")] Special special)
        {
            if (ModelState.IsValid)
            {
                db.Specials.Add(special);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(special);
        }

        // GET: Specials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Special special = db.Specials.Find(id);
            if (special == null)
            {
                return HttpNotFound();
            }
            return View(special);
        }

        // POST: Specials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Specials_ID,Name,SpecialBeginningDate,SpecialEndDate,SpecialStartTime,SpecialEndTime,Active")] Special special)
        {
            if (ModelState.IsValid)
            {
                db.Entry(special).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(special);
        }

        // GET: Specials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Special special = db.Specials.Find(id);
            if (special == null)
            {
                return HttpNotFound();
            }
            return View(special);
        }

        // POST: Specials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Special special = db.Specials.Find(id);
            db.Specials.Remove(special);
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
