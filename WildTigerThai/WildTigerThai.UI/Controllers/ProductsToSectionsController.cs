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
    public class ProductsToSectionsController : Controller
    {
        private WildTigerThaiDBEntities db = new WildTigerThaiDBEntities();

        // GET: ProductsToSections
        public ActionResult Index()
        {
            var productsToSections = db.ProductsToSections.Include(p => p.Product).Include(p => p.Section);
            return View(productsToSections.ToList());
        }

        // GET: ProductsToSections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsToSection productsToSection = db.ProductsToSections.Find(id);
            if (productsToSection == null)
            {
                return HttpNotFound();
            }
            return View(productsToSection);
        }

        // GET: ProductsToSections/Create
        public ActionResult Create()
        {
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "ProductName");
            ViewBag.Section_ID = new SelectList(db.Sections, "Section_ID", "Name");
            return View();
        }

        // POST: ProductsToSections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductToSection_ID,Product_ID,Section_ID")] ProductsToSection productsToSection)
        {
            if (ModelState.IsValid)
            {
                db.ProductsToSections.Add(productsToSection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "ProductName", productsToSection.Product_ID);
            ViewBag.Section_ID = new SelectList(db.Sections, "Section_ID", "Name", productsToSection.Section_ID);
            return View(productsToSection);
        }

        // GET: ProductsToSections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsToSection productsToSection = db.ProductsToSections.Find(id);
            if (productsToSection == null)
            {
                return HttpNotFound();
            }
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "ProductName", productsToSection.Product_ID);
            ViewBag.Section_ID = new SelectList(db.Sections, "Section_ID", "Name", productsToSection.Section_ID);
            return View(productsToSection);
        }

        // POST: ProductsToSections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductToSection_ID,Product_ID,Section_ID")] ProductsToSection productsToSection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(productsToSection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Product_ID = new SelectList(db.Products, "Product_ID", "ProductName", productsToSection.Product_ID);
            ViewBag.Section_ID = new SelectList(db.Sections, "Section_ID", "Name", productsToSection.Section_ID);
            return View(productsToSection);
        }

        // GET: ProductsToSections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProductsToSection productsToSection = db.ProductsToSections.Find(id);
            if (productsToSection == null)
            {
                return HttpNotFound();
            }
            return View(productsToSection);
        }

        // POST: ProductsToSections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProductsToSection productsToSection = db.ProductsToSections.Find(id);
            db.ProductsToSections.Remove(productsToSection);
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
