using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Repository
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contacts>> ListAsync();
    }
}