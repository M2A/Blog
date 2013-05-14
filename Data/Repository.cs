using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yara.Blog.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _context;
        private IDbSet<T> _objSet;

        public Repository(DbContext context)
        {
            _context = context;
            //_objSet = _context.CreateObjectSet<T>();
            _objSet = _context.Set<T>();
        }

        public T NewEntityInstance()
        {
            return _context.Set<T>().Create<T>();
        }

        public void Add(T item)
        {
            _objSet.Add(item);
        }

        public void Remove(T item)
        {
            _objSet.Remove(item);
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



        public static string Test()
        {
            int i = 1;
            return "This is a test";    
        }

    }


}
