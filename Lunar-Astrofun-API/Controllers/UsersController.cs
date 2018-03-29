using Microsoft.AspNetCore.Mvc;
using Lunar.Astrofun.Infrastructure.DTO;
using Lunar.Astrofun.Infrastructure.Services;
using Lunar.Astrofun.Infrastructure.Commands.Users;
using System.Collections.Generic;

namespace Lunar.Astrofun.API.Controllers
{
    [Route("[controller]")]
    public class Users : Controller
    {
        private readonly IUserService _userService;

        public Users(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public UserDto Get(string email)
            => _userService.Get(email);

        [HttpGet]
        public IEnumerable<UserDto> GetAll()
            => _userService.GetAll();

        [HttpPost("")]
        public void Post([FromBody]CreateUser request)
        {
            _userService.Register(request.Email, request.Username, request.Password);
        }
    }
}
