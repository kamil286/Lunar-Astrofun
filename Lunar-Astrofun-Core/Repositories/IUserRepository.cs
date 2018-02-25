using System;
using Lunar.Astrofun.Core.Domain;
using System.Collections.Generic;

namespace Lunar.Astrofun.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(string email);
        User Get(Guid id);
        IEnumerable<User> GetAll();
        void Add(User user);
        void Update(User user);
        void Remove(Guid id);
    }
}
