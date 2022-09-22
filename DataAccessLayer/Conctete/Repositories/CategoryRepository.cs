using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conctete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c= new Context();
        DbSet<Category> _object;

        public void Delete(Category p) //Remove silme
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(Category p) //Add ekleme
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList(); //Tolist verileri listelemeye yarar.
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }

        //Find verileri bulmaya yarar
    }
}
