using Microsoft.EntityFrameworkCore;
using PracticeApi.Context;
using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(SqlContext context) : base(context)
        {

        }

        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _context.User.ToListAsync();
        }
    }
}