using Finzo.Models;
using Finzo.Repository;

namespace Finzo.Services
{
    public class UserService
    {

        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepositpry)
        {
            _userRepository = userRepositpry;
        }

        public async Task<LoginResult> validateLogin(Users user)
        {
            return await _userRepository.validateLogin(user);
        }

    }
}
