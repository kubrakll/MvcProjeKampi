using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HomeworkManager : IHomework
    {
        IHomework _homeworkdal;


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

    }
}
