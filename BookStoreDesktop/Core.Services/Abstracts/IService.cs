using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Services.Abstracts
{
    public interface IService<T>
    {
        int Count();
        int Count(Expression<Func<T, bool>> predicate);
        T GetSingle(string id);
        T GetSingle(Expression<Func<T, bool>> predicate);
        IEnumerable<T> Get();
        IEnumerable<T> Get(int pag, int element);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        dynamic Insert(T entity);
        dynamic Insert(IEnumerable<T> list);
        dynamic Update(T entity);
        dynamic Update(IEnumerable<T> list);
        dynamic Delete(string id);
        dynamic Delete(IEnumerable<string> ids);
    }
}
