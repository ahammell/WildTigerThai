using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildTigerThai.DATA.EF.Metadata
{
    public class ProductToSectionsMetadada
    {
        //public int ProductToSection_ID { get; set; }
        [Display(Name = "Product")]
        public int Product_ID { get; set; }
        [Display(Name = "Section")]
        public int Section_ID { get; set; }
    }
    [MetadataType(typeof(ProductToSectionsMetadada))]
    public partial class ProductToSection { }
}
