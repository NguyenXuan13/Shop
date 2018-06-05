namespace ShopOnline.Data.Infracstructes
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}