using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdarShop.Data.Infrastructure;
using EdarShop.Model.Models;

namespace EdarShop.Data.Reponsitories
{
    public interface IMenuRepository : IRepository<Menu>
    {

    }
    public class MenuRepository:RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
