using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

public interface IRepository<T> where T : class
{
    Task <T> GetById(int id);
    Task <IEnumerable<T>> GetAll();
    IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    Task Add(T entity);
    Task AddRange(IEnumerable<T> entities);
    Task Remove(T entity);
    Task RemoveRange(IEnumerable<T> entities);
    Task Update(T entity);
    Task Remove(object id);
}