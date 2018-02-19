using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdarShop.Data.Infrastructure;
using EdarShop.Model.Models;

namespace EdarShop.Data.Reponsitories
{
    public interface IProductRepository : IRepository<Product>
    {

    }
    public class ProductRepository:RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
