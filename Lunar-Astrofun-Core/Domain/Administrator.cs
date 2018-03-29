using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Core.Domain
{
    public class Admin
    {
        public Guid Id { get; protected set; }
        public User AdminPersona { get; protected set; }
        public IEnumerable<User> RegisteredUsers { get; protected set; }
        public IEnumerable<Thumbnail> CreatedThumbnails { get; protected set; }

        protected Admin() { }

        public Admin(User adminPersona, IEnumerable<User> registeredUsers,
            IEnumerable<Thumbnail> createdThumbnails)
        {
            Id = Guid.NewGuid();
            AdminPersona = adminPersona;
            RegisteredUsers = registeredUsers;
            CreatedThumbnails = createdThumbnails;
        }
    }
}
