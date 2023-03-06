using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class // T DEGERİ class olmalı
    {
        Context c = new Context(); // yansıtılan data base tablolarını c nesnesine atıyoruz
        DbSet<T>_object; // T degerine karşılık gelen sınıfı tutuyor

        public GenericRepository()
        {
            _object = c.Set<T>(); // dışardan gönderdigimiz deger neyse o olcak
        }
        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Abstract.Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            c.SaveChanges();
        }
    }
}
