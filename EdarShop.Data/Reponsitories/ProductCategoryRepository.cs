using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdarShop.Data.Infrastructure;
using EdarShop.Model.Models;

namespace EdarShop.Data.Reponsitories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {

    }
    public class ProductCategoryRepository:RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
