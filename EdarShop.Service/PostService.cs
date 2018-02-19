using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EdarShop.Data.Infrastructure;
using EdarShop.Data.Reponsitories;
using EdarShop.Model.Models;
using System.Linq;
using System.Xml.Linq;

namespace EdarShop.Service
{
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPasing(int page, int pageSize, out int totalRow);
        IEnumerable<Post> GetAllByCategoryPasing(int categoryId, int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPasing(string tag,int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[]  {"PostCategory"});
        }

        public IEnumerable<Post> GetAllPasing(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllByCategoryPasing(int categoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x=>x.CategoryID == categoryId && x.Status, out totalRow, page, pageSize,new string[] {"PostCategory"});
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public IEnumerable<Post> GetAllByTagPasing(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetAllByTag( tag, page, pageSize, out totalRow);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
