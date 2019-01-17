using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildTigerThai.DATA.EF.Metadata
{
    public class ProductToSpecialsMetadata
    {
        //public int ProductToSpecial_ID { get; set; }
        [Display(Name ="Product")]
        public int Product_ID { get; set; }
        [Display(Name ="Special")]
        public int Special_ID { get; set; }
        [Display(Name = "Special Price")]
        [DisplayFormat(NullDisplayText = "N/A", DataFormatString = "{0:c}")]
        public decimal SpecialPrice { get; set; }
        public bool Active { get; set; }
    }
    [MetadataType(typeof(ProductToSpecialsMetadata))]
    public partial class ProductToSpecial { }
}
