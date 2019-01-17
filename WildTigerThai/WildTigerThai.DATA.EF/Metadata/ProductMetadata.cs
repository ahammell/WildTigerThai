using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildTigerThai.DATA.EF.Metadata
{
    public class ProductMetadata
    {
        //public int Product_ID { get; set; }
        //public int ProductType_ID { get; set; }
        [Display(Name ="Product Name")]
        [StringLength(100, ErrorMessage ="Should not exceed 100 characters")]
        [Required(ErrorMessage ="*Required")]
        public string ProductName { get; set; }
        [Display(Name = "Product Description")]
        [StringLength(100, ErrorMessage = "Should not exceed 300 characters")]
        [Required(ErrorMessage = "*Required")]
        public string Description { get; set; }
        public bool Active { get; set; }
        [DisplayFormat(NullDisplayText = "N/A", DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
        //public int ProductPhoto_ID { get; set; }
    }
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product { }
}
