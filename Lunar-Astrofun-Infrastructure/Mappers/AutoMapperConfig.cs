using AutoMapper;
using Lunar.Astrofun.Core.Repositories;
using Lunar.Astrofun.Infrastructure.Repositories;
using Lunar.Astrofun.Infrastructure.Services;
using Lunar.Astrofun.Infrastructure.Services.Interfaces;

namespace Lunar.Astrofun.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<IUserRepository, InMemoryUserRepository>();
                cfg.CreateMap<IUserService, UserService>();
                cfg.CreateMap<IThumbnailRepository, InMemoryThumbnailRepository>();
                cfg.CreateMap<IThumbanilService, ThumbnailService>();
                cfg.CreateMap<IAdministratorRepository, InMemoryAdmistratorRepository>();
                cfg.CreateMap<IAdministratorService, AdministratorService>();
            })
            .CreateMapper();
    }
}
