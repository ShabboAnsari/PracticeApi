using PracticeApi.Models;
using PracticeApi.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApi.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<IEnumerable<User>> ListAsync()
        {
            return await _userRepository.ListAsync();
       }
    }
}
