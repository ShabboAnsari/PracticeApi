using Microsoft.EntityFrameworkCore;
using PracticeApi.Context;
using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Repository
{
    public class PageRepository : BaseRepository, IPageRepository
    {
        public PageRepository(SqlContext context):base(context)
        {

        }
        public async Task<IEnumerable<Pages>> ListAsync()
        {
            return await _context.Pages.ToListAsync();
        }
    }
}