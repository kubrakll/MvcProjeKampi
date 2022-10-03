using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HomeworkManager : IHomework,IHomework2
    {
        IHomework _homeworkdal;
        IHomework2 _homeworkdal2;

        public HomeworkManager(IHomework homeworkdal)
        {
            _homeworkdal = homeworkdal;
        }

        public Category GetByID(int id)
        {
            return _homeworkdal.GetByID(id);
        }

        
        public List<Category> GetListe()
        {
            return _homeworkdal.GetListe();
        }

        Writer IHomework2.GetByID(int id)
        {
            return _homeworkdal2.GetByID(id);
        }

        List<Writer> IHomework2.GetListe()
        {
            return _homeworkdal2.GetListe();
        }
    }
}
