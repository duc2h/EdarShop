using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace EdarShop.Data.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //create an entity
        T Add(T entity);

        //marks an entity as modified
        void Update(T entity);

        //marks an entity as removed
        T Delete(T entity);

        void DeleteMulti(Expression<Func<T, bool>> where);

        T GetSingleById(int id);

        T GetSingleByCondition(Expression<Func<T, bool>> exception, string[] includes = null);

        IEnumerable<T> GetAll(string[] includes=null);

        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes=null);

        IEnumerable<T> GetMultiPaging(Expression<Func<T, bool>> filter, out int total, int index = 0, int size = 50, string[] includes = null);

        int Count(Expression<Func<T, bool>> where);

        bool CheckContains(Expression<Func<T, bool>> predicate);
    }
}
