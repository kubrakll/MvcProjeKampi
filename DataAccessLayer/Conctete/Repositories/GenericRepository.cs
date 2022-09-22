using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conctete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c=new Context();
        DbSet<T> _object;


        public void Delete(T p)
        {
            throw new NotImplementedException();
        }

        public void Insert(T p)
        {
            throw new NotImplementedException();
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(T p)
        {
            throw new NotImplementedException();
        }
    }
}
