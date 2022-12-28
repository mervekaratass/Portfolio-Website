using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {//burada  IGenericDal interface den kalıtım la aldım T yine entityim
        public void Delete(T t)
        {  //context sııfından bir nesne oluşturmam lazımki veri tabanında işlemler yapabileyim
            using var c = new Context();
            c.Remove(t); //t parametresini sil T türündeki 
            c.SaveChanges();
        }

        public List<T> GetbyFilter(Expression<Func<T, bool>> filter)
        {
            using var c = new Context();
            return c.Set<T>().Where(filter).ToList();
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
            //böylece id ile arama işlemini gerçekleştirebilicem
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();
        }
    }
}
