using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Yara.Blog.Data
{
    public interface IRepository<T> where T: class
    {
        /// <summary>
        /// Creates new instance
        /// </summary>
        /// <returns></returns>
        T NewEntityInstance();

        /// <summary>
        /// Inserts an item
        /// </summary>
        /// <param name="item"></param>
        void Add(T item);

        /// <summary>
        /// Deletes an item
        /// </summary>
        /// <param name="item"></param>
        void Remove(T item);

        /// <summary>
        /// Get an item matching to predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Get Count of items matching to predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        int GetCount(Expression<Func<T, bool>> predicate);

        /// <summery>
        /// Get All IEnumerable objects 
        /// </summery>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Get IEnumerable object matching to predicate
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);

        /// <summary>
        /// Get IEnumerable object matching to predicate,start index and count
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="start"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate, int start, int count);

        /// <summary>
        /// Saves the pending changes back into the DataContext.
        /// </summary>
        void Save();
    }
}
