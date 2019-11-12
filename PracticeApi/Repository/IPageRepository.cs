using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Repository
{
    public interface IPageRepository
    {
        Task<IEnumerable<Pages>> ListAsync();
    }
}