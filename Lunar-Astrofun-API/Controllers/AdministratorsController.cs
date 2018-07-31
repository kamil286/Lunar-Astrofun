using Lunar.Astrofun.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lunar.Astrofun.API.Controllers
{
    [Route("api/[administrator]")]
    public class AdministratorsController: Controller
    {
        private readonly IAdministratorService _administratorService;

        public AdministratorsController(IAdministratorService administratorService)
        {
            _administratorService = administratorService;
        }
   }
}
