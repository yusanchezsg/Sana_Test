using WebShopSana.DAL.Context;
using WebShopSana.DAL.Interfaces;
using WebShopSana.DAL.ProductDAL;

namespace WebShopSana.DAL.Generic
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        public ApplicationContext context { get; }

        private GenericRepositoryDAL<T> repository;
        private ProductsDAL productRepository;


        public UnitOfWork(ApplicationContext _context)
        {
            context = _context;
        }

        public GenericRepositoryDAL<T> GenericRepositoryDAL
        {
            get
            {
                if (this.repository == null)
                {
                    this.repository = new GenericRepositoryDAL<T>(context);
                }
                return this.repository;
            }
        }

        public ProductsDAL ProductsDal
        {
            get
            {
                if (this.productRepository == null)
                {
                    this.productRepository = new ProductsDAL(context);
                }
                return this.productRepository;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
