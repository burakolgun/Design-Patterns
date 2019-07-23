using System.Collections.Generic;
using Proxy.Entity;

namespace Proxy.Business
{
    public class UserRepositoryProxy : IUserRepository
    {
        private UserRepository _userRepository;

        public IEnumerable<User> GetUsers()
        {
            if (_userRepository is null)
            {
                _userRepository = new UserRepository();
            }

            return _userRepository.GetUsers();
        }

        public bool Insert(User user)
        {
            if (_userRepository is null)
            {
                _userRepository = new UserRepository();
            }

            return _userRepository.Insert(user);
        }

        public User Update(User user)
        {
            if (_userRepository is null)
            {
                _userRepository = new UserRepository();
            }

            return _userRepository.Update(user);
        }

        public bool Remove(string id)
        {
            if (_userRepository is null)
            {
                _userRepository = new UserRepository();
            }

            return _userRepository.Remove(id);
        }

        public User GetUser(string id)
        {
            if (_userRepository is null)
            {
                _userRepository = new UserRepository();
            }

            return _userRepository.GetUser(id);
        }
    }
}