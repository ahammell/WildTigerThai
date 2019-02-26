using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WildTigerThai.DATA.EF;
using WildTigerThai.Models;

namespace WildTigerThai.UI.Controllers
{
    public class PageMenuController : Controller
    {
        private WildTigerThaiDBEntities db = new WildTigerThaiDBEntities();

        // GET: PageMenu
        public ActionResult MainMenu()
        {
            var menus = db.Menus.ToList();
            menus.OrderByDescending(m => m.SectionPrecedence);
            List<ProductsToSection> pts = db.ProductsToSections.ToList();
            List<Product> products = db.Products.ToList();
            List<Photo> photos = db.Photos.ToList();
            List<PageMenuItems> menuItems = PageMenuItems.MenuItemCreator(menus, pts, products, photos);
            var vmenus = db.Menus.Include(m => m.Section).OrderBy(m => m.SectionPrecedence).ToList();
            List<Section> sections = vmenus.Select(s => s.Section).ToList();
            ViewBag.Message = vmenus;
            ViewBag.Message2 = sections;
            return View(menuItems);
        }
    }
}