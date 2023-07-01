namespace EasyCash.DataAccessLayer.Abstract;

public interface IGenericDal<TEntity> where TEntity : class
{
    Task InsertAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task<TEntity> GetByIdAsync(int id);
    Task<IEnumerable<TEntity>> GetAllAsync();
}
