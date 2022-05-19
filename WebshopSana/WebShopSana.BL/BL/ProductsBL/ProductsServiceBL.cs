using WebShopSana.BL.Generic;
using WebShopSana.DAL.Interfaces;
using WebShopSana.MODELS.Entities;

namespace WebShopSana.BL.ProductsBL
{
    public class ProductsServiceBL : GenericServiceBL<Products>, IProductsServiceBL
    {
        private readonly IUnitOfWork<Products> _unitOfWork;

        public ProductsServiceBL(IUnitOfWork<Products> unitOfWork) : base(unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int Test()
        { 
           return _unitOfWork.ProductsDal.Test();
        }
    }
}
