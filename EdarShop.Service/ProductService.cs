using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdarShop.Data.Infrastructure;
using EdarShop.Data.Reponsitories;
using EdarShop.Model.Models;

namespace EdarShop.Service
{
    public interface IProductService
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(int id);
        
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllPasing(int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByCategoryPasing(int categoryId, int page, int pageSize, out int totalRow);
        Product GetById(int id);
        IEnumerable<Product> GetAllByTagPasing(string tag,int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;
        IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll(new string[] {"ProductCategory"});
        }

        public IEnumerable<Product> GetAllPasing(int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, pageSize, page);
        }

        public IEnumerable<Product> GetAllByCategoryPasing(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page,
                pageSize);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public IEnumerable<Product> GetAllByTagPasing(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
