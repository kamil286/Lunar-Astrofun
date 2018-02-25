using System;
using System.Linq;
using System.Collections.Generic;
using Lunar.Astrofun.Core.Domain;
using Lunar.Astrofun.Core.Repositories;

namespace Lunar.Astrofun.Infrastructure.Repositories
{
    class InMemoryUserRepository : IUserRepository
    {
        public static ISet<User> _users = new HashSet<User>();

        public void Add(User user)
            => _users.Add(user);

        public User Get(string email)
            => _users.Single(x => x.Email == email.ToLowerInvariant());

        public User Get(Guid id)
            => _users.Single(x => x.Id == id);

        public IEnumerable<User> GetAll()
            => _users;

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user) { }
    }
}
