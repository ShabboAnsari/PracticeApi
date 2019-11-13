using PracticeApi.Models;
using PracticeApi.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public class Pageservice:IPageService
    {
        private readonly IPageRepository _pageRepository;
        public Pageservice(IPageRepository pagerepository)
        {
            _pageRepository = pagerepository;   
        }
        public async Task<IEnumerable<Pages>> ListAsync()
        {
            return await _pageRepository.ListAsync();
        }
    }
}
