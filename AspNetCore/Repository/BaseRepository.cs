using PracticeApi.Context;

namespace PracticeApi.Repository
{
    public abstract class BaseRepository
    {
        protected readonly SqlContext _context;

        public BaseRepository(SqlContext context)
        {
            _context = context;
        }
    }
}