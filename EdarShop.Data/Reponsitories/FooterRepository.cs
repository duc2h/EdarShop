using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdarShop.Data.Infrastructure;
using EdarShop.Model.Models;

namespace EdarShop.Data.Reponsitories
{
    public interface IFooterRepository : IRepository<Footer>
    {

    }
    public class FooterRepository:RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
