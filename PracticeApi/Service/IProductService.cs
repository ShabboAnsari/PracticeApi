using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public interface IProductService
    {
        Task<IEnumerable<Products>> ListAsync();
    }
}
