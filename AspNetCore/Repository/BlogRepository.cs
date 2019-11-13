using Microsoft.EntityFrameworkCore;
using PracticeApi.Context;
using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Repository
{
    public class BlogsRepository : BaseRepository, IBlogsRepository
    {
        public BlogsRepository(SqlContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Blogs>> ListAsync()
        {
            return await _context.Blogs.ToListAsync();
        }
    }
}