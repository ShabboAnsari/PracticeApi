using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public interface IPageService
    {
        Task<IEnumerable<Pages>> ListAsync();
    }
}
