using EasyCash.DataAccessLayer.Abstract;
using EasyCash.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EasyCash.DataAccessLayer.Repositories;

public class GenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<TEntity> _dbSet;

    public GenericRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<TEntity>();
    }
    public Task DeleteAsync(TEntity entity)
    {
        return Task.FromResult(_dbSet.Remove(entity));

    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task InsertAsync(TEntity entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public Task UpdateAsync(TEntity entity)
    {
        return Task.FromResult(_dbSet.Update(entity));
    }
}
