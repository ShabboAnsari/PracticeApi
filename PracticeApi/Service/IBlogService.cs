using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public interface IBlogService
    {
        Task<IEnumerable<Blogs>> ListAsync();
    }
}
