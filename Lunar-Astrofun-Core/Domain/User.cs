using System;

namespace Lunar.Astrofun.Core.Domain
{
    public class User
    {
        public Guid Id { get; protected set; }
        public string UserName { get; protected set; }
        public string FullName { get; protected set; }
        public string Email { get; protected set; }
        public string Password { get; protected set; }
        public string Salt { get; protected set; }
        public DateTime DateOfBirth { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        protected User() { }

        public User(string email, string username, 
            string password, string salt)
        {
            Id = Guid.NewGuid();
            Email = email;
            UserName = username;
            Password = password;
            Salt = salt;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
 