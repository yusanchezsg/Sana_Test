using WebShopSana.DAL.Interfaces;
using WebShopSana.MODELS.Entities;

namespace WebShopSana.DAL.ProductDAL
{
    public interface IProductsDAL : IGenericRepositoryDAL<Products>
    {
        int Test();
    }
}
