using WebShopSana.DAL.Context;
using WebShopSana.DAL.Generic;

namespace WebShopSana.DAL.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        ApplicationContext context { get; }

        GenericRepositoryDAL<T> GenericRepositoryDAL { get; }

        void Save();
    }
}
