using Microsoft.EntityFrameworkCore;
using PracticeApi.Context;
using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Repository
{
    public class ContactRepository : BaseRepository, IContactRepository
    {

        public ContactRepository(SqlContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Contacts>> ListAsync()
        {
            return await _context.Contacts.ToListAsync();
        }
    }
}