using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
    public class Heading
    {   
        [Key]
        public int HeadingID { get; set; } // veritabanına yansıyan sutun başlıkları,

        [StringLength(50)]
        public string HeadingName { get; set; }

        public DateTime HeadingDate { get; set; }

        // category ilişkisi
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //content ilişkisi

        public ICollection<Content> Contents { get; set; }

        // writer ilişkisi

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }


    }
}
