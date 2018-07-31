using System;
using System.Linq;
using System.Collections.Generic;
using Lunar.Astrofun.Core.Domain;
using Lunar.Astrofun.Core.Repositories;

namespace Lunar.Astrofun.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>()
        {
            new User("user1@email.com", "user1", "secret", "salt"),
            new User("user2@email.com", "user2", "secret", "salt"),
            new User("user3@email.com", "user3", "secret", "salt")
        };

        public void Add(User user)
            => _users.Add(user);

        public User Get(string email)
            => _users.FirstOrDefault(x => x.Email == email.ToLowerInvariant());

        public User Get(Guid id)
            => _users.FirstOrDefault(x => x.Id == id);

        public IEnumerable<User> GetAll()
            => _users;

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        =>  throw new NotImplementedException();
    }
}
