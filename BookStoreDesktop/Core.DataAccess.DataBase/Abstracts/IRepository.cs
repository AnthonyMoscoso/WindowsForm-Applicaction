using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.DataBase.Abstracts
{
    public interface IRepository<T>
    {
        int Count();
        int Count(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Get();
        IEnumerable<T> Get(int elements, int pag);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        T GetSingle(string id);
        T GetSingle(Expression<Func<T, bool>> predicate);
        dynamic Update(T entity);
        dynamic Insert(T entity);
        dynamic Delete(string id);
        dynamic Save();
        dynamic SqlQuery(string query);
        void Dispose();
    }
}
