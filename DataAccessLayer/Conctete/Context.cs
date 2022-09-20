using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conctete
{
    //Prop larımız tablo ismi olarak sql de karşılık bulacak.
    public class Context : DbContext
    {
        //DbSet<EntityLayer katmanında tanımladığımız sınıflar olcak>
        //About ile Abouts arasındaki fark; About proje içindeki sınıfımın ismi About ise sql de veritabanına yansıcak kısım.
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }

    }
}
