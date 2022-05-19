using WebShopSana.DAL.Context;
using WebShopSana.DAL.Generic;
using WebShopSana.DAL.ProductDAL;

namespace WebShopSana.DAL.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        ApplicationContext context { get; }

        GenericRepositoryDAL<T> GenericRepositoryDAL { get; }
        ProductsDAL ProductsDal { get; }

        void Save();
    }
}
