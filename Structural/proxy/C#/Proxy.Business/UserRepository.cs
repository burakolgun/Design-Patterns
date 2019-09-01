using System;
using System.Collections.Generic;
using System.Linq;
using Proxy.Entity;

namespace Proxy.Business
{
    public class UserRepository : IUserRepository
    {
        private readonly ICollection<User> _users = new List<User>();

        public IEnumerable<User> GetUsers()
        {
            return _users.Where(q => !q.IsDeleted);
        }

        public bool Insert(User user)
        {
            _users.Add(user);
            return true;
        }

        public User Update(User user)
        {
            var userEntity = _users.FirstOrDefault(q => !q.IsDeleted && q.Id.Equals(user.Id));

            if (userEntity is null)
            {
                return null;
            }

            userEntity.ModifiedAt = DateTime.Now;
            userEntity.Address = user.Address;
            userEntity.Age = user.Age;
            userEntity.Firstname = user.Firstname;
            userEntity.Lastname = user.Lastname;

            return userEntity;
        }

        public bool Remove(string id)
        {
            var user = _users.FirstOrDefault(q => !q.IsDeleted && q.Id.Equals(id));

            if (user is null)
            {
                return false;
            }

            _users.Remove(user);
            return true;
        }

        public User GetUser(string id)
        {
            return _users.FirstOrDefault(q => !q.IsDeleted && q.Id.Equals(id));
        }
    }
}