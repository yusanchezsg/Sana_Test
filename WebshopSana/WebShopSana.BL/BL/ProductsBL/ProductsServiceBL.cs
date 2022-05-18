using WebShopSana.BL.Generic;
using WebShopSana.DAL.Interfaces;
using WebShopSana.MODELS.Models;

namespace WebShopSana.BL.ProductsBL
{
    public class ProductsServiceBL : GenericServiceBL<Products>, IProductsServiceBL
    {
        public ProductsServiceBL(IUnitOfWork<Products> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
