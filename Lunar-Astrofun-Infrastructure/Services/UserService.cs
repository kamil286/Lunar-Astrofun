using System;
using System.Collections.Generic;
using AutoMapper;
using Lunar.Astrofun.Core.Domain;
using Lunar.Astrofun.Core.Repositories;
using Lunar.Astrofun.Infrastructure.DTO;

namespace Lunar.Astrofun.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public UserDto Get(string email)
        {
            User user = _userRepository.Get(email);
            return _mapper.Map<User, UserDto>(user);
        }

        public IEnumerable<UserDto> GetAll()
        {
            IEnumerable<User> users = _userRepository.GetAll();
            ISet<UserDto> usersDto = new HashSet<UserDto>();
            foreach (User user in users)
            {
                UserDto userDto = _mapper.Map<User, UserDto>(user);
                usersDto.Add(userDto);
            }

            return usersDto;
        }

        public void Register(string email, string username, string password)
        {
            var user = _userRepository.Get(email);
            if (user != null)
            {
                throw new Exception($"User with email {email} already exist!");
            }

            string salt = Guid.NewGuid().ToString("N");
            user = new User(email, username, password, salt);
            _userRepository.Add(user);
        }
    }
}
