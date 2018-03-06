﻿using System;
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
            var user = _userRepository.Get(email);
            return _mapper.Map<User, UserDto>(user);
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