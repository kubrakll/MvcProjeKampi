﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        // property tanımlıyoruz.
        //veritabanına yansıcak sütun kısımlarımız


        [Key]
        public int HeadingID { get; set; }

        [StringLength(50)]
        public string HeadingName { get; set; }

        //Tarihleri kısıtlamıyoruz.
        public DateTime HeadingDate { get; set; }

        //İlişkilendirme
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

        //İlişkilendirme1
        public ICollection<Content> Contents { get; set; }

        //İlişkilendirme3
        // N kısmı ICollection dur
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }
    }
}
