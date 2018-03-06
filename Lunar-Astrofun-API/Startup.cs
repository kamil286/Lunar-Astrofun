using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Lunar.Astrofun.Infrastructure.Services;
using Lunar.Astrofun.Core.Repositories;
using Lunar.Astrofun.Infrastructure.Repositories;
using Lunar.Astrofun.Infrastructure.Mappers;

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
