using System;
using System.Collections.Generic;
using System.Linq;

namespace LocalTaste.Data.Repositories.Interfaces
{
    public interface IBaseRepository<T> : IDisposable where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Attach(T entity);

        IQueryable<T> Get();
        IEnumerable<T> Where(Func<T, bool> predicate);

        T Get(int id);
        T FirstOrDefault(Func<T, bool> predicate);
    }
}
