using Lunar.Astrofun.Core.Repositories;
using Lunar.Astrofun.Infrastructure.DTO;
using Lunar.Astrofun.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Infrastructure.Services
{
    public class AdministratorService : IAdministratorService
    {
        private readonly IAdministratorRepository _administratorRepository;
        private readonly IUserRepository _userRepository;
        private readonly IThumbnailRepository _thumbnailRepository;

        public AdministratorService(IUserRepository userRepository, IThumbnailRepository thumbnailRepository,
            IAdministratorRepository administratorRepository)
        {
            _userRepository = userRepository;
            _thumbnailRepository = thumbnailRepository;
            _administratorRepository = administratorRepository;
        }

        public void Create(Guid id, UserDto adminData, IEnumerable<ThumbnailDto> createdThumbnails)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdministratorDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public AdministratorDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
