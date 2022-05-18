namespace WebShopSana.BL.Interfaces
{
    public interface IDeleteServiceBL<T> where T : class
    {
        void Remove(T entity);
    }
}
