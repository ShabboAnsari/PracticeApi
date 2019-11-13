using PracticeApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public class ContactService:IContactService
    {
        private readonly IContactService _contactRepository;
        public ContactService(IContactService contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public async Task<IEnumerable<Contacts>> ListAsync()
        {
            return await _contactRepository.ListAsync();
        }
    }
}
