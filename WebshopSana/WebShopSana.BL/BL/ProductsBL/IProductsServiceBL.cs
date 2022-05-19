using WebShopSana.BL.Interfaces;
using WebShopSana.MODELS.Entities;

namespace WebShopSana.BL.ProductsBL
{
    public interface IProductsServiceBL : IGenericServiceBL<Products>
    {
        int Test();
    }
}
