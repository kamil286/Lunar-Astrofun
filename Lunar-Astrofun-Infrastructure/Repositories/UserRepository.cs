using System;
using System.Collections.Generic;
using Lunar.Astrofun.Core.Domain;
using Lunar.Astrofun.Core.Repositories;

namespace Lunar.Astrofun.Infrastructure.Repositories
{
    class UserRepository : IUserRepository
    {
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public User Get(string email)
        {
            throw new NotImplementedException();
        }

        public User Get(Guid guid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid guid)
        {
            throw new NotImplementedException();
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
