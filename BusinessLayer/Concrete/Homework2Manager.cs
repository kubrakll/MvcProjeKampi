using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class Homework2Manager : IHomework2
    {
        IHomework2 _homework2;

        public Homework2Manager(IHomework2 homework2)
        {
            _homework2 = homework2;
        }

        public Writer GetByID(int id)
        {
            return _homework2.GetByID(id);
        }

        public List<Writer> GetListe()
        {
            return _homework2.GetListe();
        }
    }
}
