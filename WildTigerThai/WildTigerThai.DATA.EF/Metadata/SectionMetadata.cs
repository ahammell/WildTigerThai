using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildTigerThai.DATA.EF.Metadata
{
    public class SectionMetadata
    {
        //public int Section_ID { get; set; }
        [Display(Name = "Section Name")]
        [StringLength(100, ErrorMessage ="Should not exceed 100 characters")]
        [Required(ErrorMessage ="*Required")]
        public string Name { get; set; }
        public bool Active { get; set; }
    }
    [MetadataType(typeof(SectionMetadata))]
    public partial class Section { }
}
