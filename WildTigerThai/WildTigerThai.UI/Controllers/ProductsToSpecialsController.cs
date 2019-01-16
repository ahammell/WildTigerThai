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
    public class ProductsToSpecialsController : Controller
    {
        private WildTigerThaiDBEntities db = new WildTigerThaiDBEntities();

        // GET: ProductsToSpecials
        public ActionResult Index()
        {
            var productsToSpecials = db.ProductsToSpecials.Include(p => p.Product).Include(p => p.Special);
            return View(productsToSpecials.ToList());
        }

        // GET: ProductsToSpecials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsToSpecial productsToSpecial = db.ProductsToSpecials.Find(id);
            if (productsToSpecial == null)
            {
                return HttpNotFound();
            }
            return View(productsToSpecial);
        }

        // GET: ProductsToSpecials/Create
        public ActionResult Create()
        {
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "ProductName");
            ViewBag.Special_ID = new SelectList(db.Specials, "Special_ID", "Name");
            return View();
        }

        // POST: ProductsToSpecials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Product_ID,Special_ID,SpecialPrice,Active")] ProductsToSpecial productsToSpecial)
        {
            if (ModelState.IsValid)
            {
                db.ProductsToSpecials.Add(productsToSpecial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "ProductName", productsToSpecial.Product_ID);
            ViewBag.Special_ID = new SelectList(db.Specials, "Special_ID", "Name", productsToSpecial.Special_ID);
            return View(productsToSpecial);
        }

        // GET: ProductsToSpecials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsToSpecial productsToSpecial = db.ProductsToSpecials.Find(id);
            if (productsToSpecial == null)
            {
                return HttpNotFound();
            }
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "ProductName", productsToSpecial.Product_ID);
            ViewBag.Special_ID = new SelectList(db.Specials, "Special_ID", "Name", productsToSpecial.Special_ID);
            return View(productsToSpecial);
        }

        // POST: ProductsToSpecials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Product_ID,Special_ID,SpecialPrice,Active")] ProductsToSpecial productsToSpecial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productsToSpecial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "ProductName", productsToSpecial.Product_ID);
            ViewBag.Special_ID = new SelectList(db.Specials, "Special_ID", "Name", productsToSpecial.Special_ID);
            return View(productsToSpecial);
        }

        // GET: ProductsToSpecials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsToSpecial productsToSpecial = db.ProductsToSpecials.Find(id);
            if (productsToSpecial == null)
            {
                return HttpNotFound();
            }
            return View(productsToSpecial);
        }

        // POST: ProductsToSpecials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductsToSpecial productsToSpecial = db.ProductsToSpecials.Find(id);
            db.ProductsToSpecials.Remove(productsToSpecial);
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
