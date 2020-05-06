using System;
using System.Linq;
using System.Linq.Expressions;

namespace CIB.PhoneBook.DAL.Interfaces
{
    public interface IRepository<T>
    {
        T Add(T entity);
        T Remove(T entity);
        T Update(object key, T entity);
        IQueryable<T> GetAll();
        T Get(object key);
        T SearchFirst(Expression<Func<T, bool>> predicate);
        IQueryable<T> SearchFor(Expression<Func<T, bool>> predicate);
        void SaveChanges();
    }
}
