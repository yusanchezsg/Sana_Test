namespace WebShopSana.DAL.Interfaces
{
    public interface IDeleteEntity<TEntity> where TEntity : class
    {
        void Remove(TEntity entity);
    }
}
