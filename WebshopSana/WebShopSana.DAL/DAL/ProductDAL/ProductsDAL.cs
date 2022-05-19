using WebShopSana.DAL.Context;
using WebShopSana.DAL.Generic;
using WebShopSana.MODELS.Entities;

namespace WebShopSana.DAL.ProductDAL
{
    public class ProductsDAL : GenericRepositoryDAL<Products>, IProductsDAL
    {
        public ProductsDAL(ApplicationContext applicationContext) : base(applicationContext)
        {
        }

        public int Test()
        {
            return 1 + 2;
        }
    }
}
