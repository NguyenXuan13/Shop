using System;

namespace ShopOnline.Data.Infracstructes
{
    public interface IDbFactory : IDisposable
    {
        ShopOnlineDbContext Init();
    }
}