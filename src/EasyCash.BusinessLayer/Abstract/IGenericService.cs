namespace EasyCash.BusinessLayer.Abstract;

public interface IGenericService<TEntity> where TEntity : class
{
    Task TInsertAsync(TEntity entity);
    Task TUpdateAsync(TEntity entity);
    Task TDeleteAsync(TEntity entity);
    Task<TEntity> TGetByIdAsync(int id);
    Task<IEnumerable<TEntity>> TGetAllAsync();
}
