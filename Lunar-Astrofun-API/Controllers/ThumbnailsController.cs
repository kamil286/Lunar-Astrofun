using Lunar.Astrofun.Infrastructure.DTO;
using Lunar.Astrofun.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lunar.Astrofun.API.Controllers
{
    [Route("api/[controller]")]
    public class ThumbnailsController: Controller
    {
        private readonly IThumbanilService _thumbnailService;

        public ThumbnailsController(IThumbanilService thumbanilService)
        {
            _thumbnailService = thumbanilService;
        }

        [HttpGet]
        public IEnumerable<ThumbnailDto> GetAll()
            => _thumbnailService.GetAll();
   
    }
}
