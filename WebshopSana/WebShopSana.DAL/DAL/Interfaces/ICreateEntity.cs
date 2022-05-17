namespace WebShopSana.DAL.Interfaces
{
    public interface ICreateEntity<TEntity> where TEntity : class
    {
        TEntity Create(TEntity entity);
    }
}
