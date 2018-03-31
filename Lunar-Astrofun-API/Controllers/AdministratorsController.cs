using Lunar.Astrofun.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        // Here will be code which will handle CRUD operations on mock collection of administrators.
   }
}
