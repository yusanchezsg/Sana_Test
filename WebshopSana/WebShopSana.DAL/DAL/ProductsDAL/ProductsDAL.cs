using WebShopSana.DAL.Context;
using WebShopSana.DAL.Generic;
using WebShopSana.MODELS.Models;

namespace WebShopSana.DAL.ProductsDAL
{
    public class ProductsDAL : GenericRepositoryDAL<Products>, IProductsDAL
    {
        public ProductsDAL(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}
