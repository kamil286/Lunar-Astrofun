using Lunar.Astrofun.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Infrastructure.Services.Interfaces
{
    public interface IAdministratorService
    {
        AdministratorDto GetById(Guid id);
        IEnumerable<AdministratorDto> GetAll();
        void Create(Guid id, UserDto adminData, IEnumerable<ThumbnailDto> createdThumbnails);
    }
}
