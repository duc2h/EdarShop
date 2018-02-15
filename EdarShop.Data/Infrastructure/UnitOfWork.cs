

namespace EdarShop.Data.Infrastructure
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private EdarShopDbContext dbContext;

        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public EdarShopDbContext DbContext => dbContext ?? (dbContext = dbFactory.Init());

        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
