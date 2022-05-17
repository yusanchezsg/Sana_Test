namespace WebShopSana.DAL.Interfaces
{
    public interface IGenericRepositoryDAL<TEntitiy> : ICreateEntity<TEntitiy>, IGetEntity<TEntitiy>, IUpdateEntity<TEntitiy>, IDeleteEntity<TEntitiy>
                       where TEntitiy : class
    { 
    }
}
