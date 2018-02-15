using System;

namespace EdarShop.Data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {

        EdarShopDbContext Init();
    }
}
