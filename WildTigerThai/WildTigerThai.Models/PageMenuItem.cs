using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildTigerThai.DATA.EF;

namespace WildTigerThai.Models
{
    public class PageMenuItems
    {

        //properties
        [Key]
        public int ItemNumber { get; set; }
        public int PageMenuNumber { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] ProductPhoto { get; set; }
        public int SectionNumber { get; set; }


        public PageMenuItems()
        {

        }
        public static List<PageMenuItems> MenuItemCreator(List<Menu> menus, List<ProductsToSection> productsInSections, List<Product> products, List<Photo> photos)
        {
            int key = 1;
            List<PageMenuItems> pageMenuItems = new List<PageMenuItems>();
            foreach (Menu menu in menus)
            {
                foreach (ProductsToSection pts in productsInSections)
                {
                    foreach (Product product in products)
                    {
                        if (pts.Section_ID == menu.Section_ID && product.Product_ID == pts.Product_ID)
                        {
                            bool alreadyInList = pageMenuItems.Any(item => item.ProductName == product.ProductName);
                            if (!alreadyInList)
                            {
                                PageMenuItems item = new PageMenuItems();
                                item.ItemNumber = key;
                                item.PageMenuNumber = menu.MenuNumber;
                                item.ProductName = product.ProductName;
                                item.Description = product.Description;
                                item.Price = product.Price;
                                foreach (Photo photo in photos)
                                {

                                    if (product.ProductPhoto_ID == photo.Photo_ID)
                                    {
                                        item.ProductPhoto = photo.File;
                                    }
                                }
                                item.SectionNumber = pts.Section_ID;
                                pageMenuItems.Add(item);
                                key++;
                            }
                        }
                    }
                }

            }
            return pageMenuItems;
        }
    }
}
