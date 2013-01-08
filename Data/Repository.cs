using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yara.Blog.Data
{
    public class Repository<T> : IRepository<T> where T: class
    {
        protected ObjectContext _context;
        private IObjectSet<T> _objSet;  

        public Repository(ObjectContext context)
        {
            _context = context;
            _objSet = _context.CreateObjectSet<T>();
        }

        public T NewEntityInstance()
        {
            return _context.CreateObject<T>();
        }

        public void Add(T item)
        {
            _objSet.AddObject(item);
        }

        public void Remove(T item)
        {
            _objSet.DeleteObject(item);
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _objSet.FirstOrDefault(predicate);
        }

        public int GetCount(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _objSet.Count(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _objSet;
        }

        public IEnumerable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _objSet.Where(predicate);
        }

        public IEnumerable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate, int start, int count)
        {
            return _objSet.Where(predicate).Skip(start).Take(count);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
