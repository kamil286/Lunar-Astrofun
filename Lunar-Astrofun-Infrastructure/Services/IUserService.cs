using Lunar.Astrofun.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Infrastructure.Services
{
    public interface IUserService
    {
        UserDto Get(string email);
        IEnumerable<UserDto> GetAll();
        void Register(string email, string username, string password);
    }
}
