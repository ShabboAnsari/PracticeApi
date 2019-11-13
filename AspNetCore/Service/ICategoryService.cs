using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}