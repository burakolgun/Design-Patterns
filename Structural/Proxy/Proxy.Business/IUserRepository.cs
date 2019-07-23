using System.Collections.Generic;
using Proxy.Entity;

namespace Proxy.Business
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        bool Insert(User user);
        User Update(User user);
        bool Remove(string id);
        User GetUser(string id);
    }
}