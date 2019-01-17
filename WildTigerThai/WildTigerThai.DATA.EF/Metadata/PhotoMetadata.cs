using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildTigerThai.DATA.EF.Metadata
{
    public class PhotoMetadata
    {
        //public int Photo_ID { get; set; }
        //public int PhotoType_ID { get; set; }
        [Display(Name = "Photo")]
        public byte[] File { get; set; }
    }
    [MetadataType(typeof(PhotoMetadata))]
    public partial class Photo { }
}
