namespace WebShopSana.BL.Interfaces
{
    public interface IGetServiceBL<T> where T : class
    {
        T Get(int Id);
        List<T> Get();
    }
}
