using PracticeApi.Models;
using PracticeApi.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public class BlogService : IBlogService
    {
        private readonly IBlogsRepository _BlogsRepository;
        public BlogService(IBlogsRepository blogsRepository)
        {
            _BlogsRepository = blogsRepository;
        }
        public async Task<IEnumerable<Blogs>> ListAsync()
        {
            return await _BlogsRepository.ListAsync();
         }

      
    }
}
