using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Lunar.Astrofun.Infrastructure.Services;
using Lunar.Astrofun.Core.Repositories;
using Lunar.Astrofun.Infrastructure.Repositories;
using Lunar.Astrofun.Infrastructure.Mappers;
using Lunar.Astrofun.Infrastructure.Services.Interfaces;

namespace Lunar_Astrofun_API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, InMemoryUserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IThumbnailRepository, InMemoryThumbnailRepository>();
            services.AddScoped<IThumbnailService, ThumbnailService>();
            services.AddScoped<IAdministratorRepository, InMemoryAdmistratorRepository>();
            services.AddScoped<IAdministratorService, AdministratorService>();
            services.AddSingleton(AutoMapperConfig.Initialize());
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
