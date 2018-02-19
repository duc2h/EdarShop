using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdarShop.Data.Infrastructure;
using EdarShop.Data.Reponsitories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EdarShop.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory _dbFactory;
        IUnitOfWork _unitOfWork;
        IPostCategoryRepository _postCategoryRepository;
        [TestInitialize()]
        public void Initialize()
        {
            _dbFactory = new DbFactory();
            _postCategoryRepository = new PostCategoryRepository(_dbFactory);
            _unitOfWork = new UnitOfWork(_dbFactory);
        }

    }
}
