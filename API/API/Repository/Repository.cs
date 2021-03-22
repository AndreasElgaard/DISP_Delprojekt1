using API.DataBaseContext;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public abstract class Repository<T> : IRepository<T> where T : class
{
    protected readonly ApplicationContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(ApplicationContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();

    }

    public async Task Add(T entity)
    {
        try
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine("Error",  e);
        }
        
    }

    public async Task AddRange(IEnumerable<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);
    }

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {

        var result = _dbSet.Where(expression);

        if (result == null)
            return null;

        return result;
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        var result =  await _dbSet.ToListAsync();

        if (result == null)
            return null;

        return result;
    }

    public async Task<T> GetById(int id)
    {
        var result = await _dbSet.FindAsync(id);

        if (result == null)
            return null;

        return result;
    }

    public async Task Remove(T entity)
    {
        if (_context.Entry(entity).State == EntityState.Detached)
        {
            _dbSet.Attach(entity);
        }

        _dbSet.Remove(entity);

        await _context.SaveChangesAsync();
    }

    public async Task RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);

        await _context.SaveChangesAsync();
    }

    public async Task Remove(object id)
    {
        T entityToDelete = await _dbSet.FindAsync(id);

        _dbSet.Remove(entityToDelete);

        await _context.SaveChangesAsync();
    }

    public async Task Update(T entity)
    {
        _dbSet.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;

        await _context.SaveChangesAsync();
    }
}