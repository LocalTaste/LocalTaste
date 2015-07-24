using LocalTaste.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LocalTaste.Data.Repositories
{
    public class BaseRepository<T> : Disposable, IBaseRepository<T>
        where T : class
    {
        protected LocalTasteDataContext DataContext;
        private readonly IDbSet<T> _dbset;

        protected BaseRepository(LocalTasteDataContext dbContext)
        {
            DataContext = dbContext;
            _dbset = DataContext.Set<T>();
        }

        public void Add(T entity)
        {
            _dbset.Add(entity);
            DataContext.SaveChanges();
        }

        public void Update(T entity)
        {
            DataContext.Entry(entity).State = EntityState.Modified;
            DataContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbset.Remove(entity);
            DataContext.SaveChanges();
        }

        public void Delete(Func<T, bool> where)
        {
            IEnumerable<T> objects = _dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                _dbset.Remove(obj);

            DataContext.SaveChanges();
        }

        public T Get(int id)
        {
            return _dbset.Find(id);
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return _dbset.FirstOrDefault(predicate);
        }

        public T Attach(T entity)
        {
            _dbset.Attach(entity);

            return entity;
        }

        public IQueryable<T> Get()
        {
            return _dbset;
        }

        public IEnumerable<T> Where(Func<T, bool> predicate)
        {
            return _dbset.Where(predicate);
        }
    }
}
