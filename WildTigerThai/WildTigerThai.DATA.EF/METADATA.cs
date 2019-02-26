using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildTigerThai.DATA.EF
{
    public class METADATA
    {
    }

    //PhotoMetaDATA
    public class PhotoMETADATA
    {
        [Display(Name = "Photo Type")]
        public int PhotoType_ID { get; set; }
        [Display(Name = "Photo")]
        public byte[] File { get; set; }
    }
    [MetadataType(typeof(PhotoMETADATA))]
    public partial class Photo { }

    //ProductsMETADATA
    public class ProductMETADATA
    {
        [Display(Name = "Product Name")]
        [StringLength(100, ErrorMessage = "Should not exceed 100 characters")]
        [Required(ErrorMessage = "*Required")]
        public string ProductName { get; set; }
        [Display(Name = "Product Description")]
        [StringLength(300, ErrorMessage = "Should not exceed 300 characters")]
        [UIHint("MultilineText")]
        [Required(ErrorMessage = "*Required")]
        public string Description { get; set; }
        [DisplayFormat(NullDisplayText = "N/A", DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
    }
    [MetadataType(typeof(ProductMETADATA))]
    public partial class Product { }

    //ProductsToSectionsMETADATA
    public class ProductsToSectionMETADATA
    {
        [Display(Name = "Product")]
        public int Product_ID { get; set; }
        [Display(Name = "Section")]
        public int Section_ID { get; set; }
    }
    [MetadataType(typeof(ProductsToSectionMETADATA))]
    public partial class ProductsToSection { }

    //ProductsToSpecialsMETADATA
    public class ProductsToSpecialMETADATA
    {
        [Display(Name = "Product")]
        public int Product_ID { get; set; }
        [Display(Name = "Special")]
        public int Special_ID { get; set; }
        [Display(Name = "Special Price")]
        [DisplayFormat(NullDisplayText = "N/A", DataFormatString = "{0:c}")]
        public decimal SpecialPrice { get; set; }
    }
    [MetadataType(typeof(ProductsToSpecialMETADATA))]
    public partial class ProductsToSpecial { }

    //ProductTypeMETADATA
    public class ProductTypeMETADATA
    {
        [Display(Name = "Product Description")]
        [StringLength(100, ErrorMessage = "Should not exceed 100 characters")]
        [Required(ErrorMessage = "*Required")]
        public string Description { get; set; }
    }
    [MetadataType(typeof(ProductTypeMETADATA))]
    public partial class ProductsType { }

    //SectionMETADATA
    public class SectionMETADATA
    {
        [Display(Name = "Section Name")]
        [StringLength(100, ErrorMessage = "Should not exceed 100 characters")]
        [Required(ErrorMessage = "*Required")]
        public string Name { get; set; }
    }
    [MetadataType(typeof(SectionMETADATA))]
    public partial class Section { }

    //SpecialMETADATA
    public class SpecialMETADATA
    {
        [Display(Name = "Special Name")]
        [StringLength(100, ErrorMessage = "Should not exceed 100 characters")]
        [Required(ErrorMessage = "*Required")]
        public string Name { get; set; }
        [Display(Name = "Special Beginning Date")]
        [DisplayFormat(NullDisplayText = "N/A", DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> SpecialBeginningDate { get; set; }
        [Display(Name = "Special End Date")]
        [DisplayFormat(NullDisplayText = "N/A", DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> SpecialEndDate { get; set; }
        [Display(Name = "Special Start Time")]
        [StringLength(100, ErrorMessage = "Should not exceed 100 characters")]
        public string SpecialStartTime { get; set; }
        [Display(Name = "Special End Time")]
        [StringLength(100, ErrorMessage = "Should not exceed 100 characters")]
        public string SpecialEndTime { get; set; }
    }
    [MetadataType(typeof(SpecialMETADATA))]
    public partial class Special { }

    //MenuMETADATA
    public class MenuMETADATA
    {
        //public int Menu_ID { get; set; }
        [Display(Name = "Menu")]
        [Required(ErrorMessage ="*Required")]
        public int MenuNumber { get; set; }
        [Display(Name = "Section")]
        [Required(ErrorMessage = "*Required")]
        public int Section_ID { get; set; }
        [Display(Name = "Section Precedence")]
        [Required(ErrorMessage = "*Required")]
        public int SectionPrecedence { get; set; }
        [Display(Name = "Menu Name")]
        [StringLength(50, ErrorMessage = "Should not exceed 50 characters")]
        public string MenuName { get; set; }
    }
    [MetadataType(typeof(MenuMETADATA))]
    public partial class Menu { }
}
