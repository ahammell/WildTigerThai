using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildTigerThai.DATA.EF.Metadata
{
    public class SpecialMetadata
    {
        //public int Special_ID { get; set; }
        [Display(Name = "Special Name")]
        [StringLength(100, ErrorMessage = "Should not exceed 100 characters")]
        [Required(ErrorMessage ="*Required")]
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
        public bool Active { get; set; }
    }
    [MetadataType(typeof(SpecialMetadata))]
    public partial class Special { }
}
