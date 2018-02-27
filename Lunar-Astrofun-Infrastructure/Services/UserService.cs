using System;
using Lunar.Astrofun.Core.Repositories;
using Lunar.Astrofun.Infrastructure.DTO;

namespace Lunar.Astrofun.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserDto Get(string email)
        {
            var user = _userRepository.Get(email);

            return new UserDto
            {
                Id = user.Id,
                UserName = user.UserName,
                FullName = user.FullName,
                Email = user.Email
        };
    }

    public void Register(string email, string username, string password)
    {
        var user = _userRepository.Get(email);
        if (user != null)
        {
            throw new Exception($"User with email {email} already exist!");
        }

        var salt = Guid.NewGuid().ToString("N");
        user = new Core.Domain.User(email, username, password, salt);
        _userRepository.Add(user);
    }
}
}
