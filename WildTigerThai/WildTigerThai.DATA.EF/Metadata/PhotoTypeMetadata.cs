using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildTigerThai.DATA.EF.Metadata
{
    public class PhotoTypeMetadata
    {
        //public int ProductType_ID { get; set; }
        [Display (Name = "Product Type Description")]
        [StringLength(100, ErrorMessage ="Should not exceed 100 characters")]
        [Required(ErrorMessage ="*Required")]
        public string Description { get; set; }
        public bool Active { get; set; }
    }
    [MetadataType(typeof(PhotoTypeMetadata))]
    public partial class PhotoType { }
}
