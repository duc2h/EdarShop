
namespace EdarShop.Data.Infrastructure
{
    public class DbFactory:Disposable, IDbFactory
    {
        private EdarShopDbContext dbContext;

        public EdarShopDbContext Init() => dbContext ?? (dbContext = new EdarShopDbContext());

        protected override void DisposeCore()
        {
            if (dbContext != null)
            dbContext.Dispose();
        }
    }
}
