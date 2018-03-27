using Lunar.Astrofun.Infrastructure.Commands.Thumbnails;
using Lunar.Astrofun.Infrastructure.DTO;
using Lunar.Astrofun.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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

        [HttpGet("{title}")]
        public ThumbnailDto GetByTitle(string title)
         => _thumbnailService.GetByTitle(title);


        [HttpGet]
        public IEnumerable<ThumbnailDto> GetAll()
            => _thumbnailService.GetAll();

        [HttpPost("")]
        public void Post([FromBody] ThumbnailCreation request)
        {
            _thumbnailService.Create(Guid.NewGuid(), request.Title, request.Category, request.Content);
        }
    }
}
