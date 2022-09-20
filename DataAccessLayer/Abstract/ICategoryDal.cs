using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD
        //Type Name();
        //Türü ve ismi List olan tanımlama yaptık.

        List<Category> List(); //Listeleme

        void Insert(Category p); //Ekleme, Category sınıfından gelen bir p parametresi

        void Update(Category p); //Güncelleme, 

        void Delete(Category p); //Silme



    }
}
