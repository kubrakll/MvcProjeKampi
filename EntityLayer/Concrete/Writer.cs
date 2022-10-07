using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [StringLength(50)]
        public string WriterName { get; set; }

        [StringLength(50)]
        public string WriterSurName { get; set; }

        [StringLength(300)]
        public string WriterImage { get; set; }

        [StringLength(100)]
        public String WriterAbout { get; set; }

        [StringLength(200)]
        public string WriterMail { get; set; }

        [StringLength(200)]
        public string WriterPassword { get; set; }

        [StringLength(50)]
        public string WriterTitle { get; set; }

        //İlişkilendirme3
        // 1'e N ilişkide 
        // 1 kısmı ICollection dur
        public ICollection<Heading> Headings { get; set; }

        //İlişkilendirme4
        public ICollection<Content> Contents { get; set; }

    }
}
// add-migration migname
// update-database