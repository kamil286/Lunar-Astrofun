using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Lunar.Astrofun.Core.Domain;
using Lunar.Astrofun.Core.Repositories;
using Lunar.Astrofun.Infrastructure.DTO;

namespace Lunar.Astrofun.Infrastructure.Services
{
    public class ThumbnailService : IThumbanilService
    {
        private readonly IThumbnailRepository _thumbnailRepository;
        private readonly IMapper _mapper;

        public ThumbnailService(IThumbnailRepository thumbnailRepository, IMapper mapper)
        {
            _thumbnailRepository = thumbnailRepository;
            _mapper = mapper;
        }

        public void Create(Guid id, string title, string category, string content)
        {
            var thumbnail = _thumbnailRepository.Get(id);
            if (thumbnail != null)
            {
                throw new Exception($"Thumbnail with this id {id} already exist!");
            }

            thumbnail = new Thumbnail(id, title, category, content);
            _thumbnailRepository.Add(thumbnail);
        }

        public ThumbnailDto Get(Guid id)
        {
            var thumbnail = _thumbnailRepository.Get(id);
            return _mapper.Map<Thumbnail, ThumbnailDto>(thumbnail);
        }

        IEnumerable<ThumbnailDto> IThumbanilService.GetAll()
        {
            var thumbnails = _thumbnailRepository.GetAll();
            var thumbnailsCollections = new HashSet<ThumbnailDto>();
            foreach (var thumbnail in thumbnails)
            {
                var thumbnailDto = _mapper.Map<Thumbnail, ThumbnailDto>(thumbnail);
                thumbnailsCollections.Add(thumbnailDto);
            }

            return thumbnailsCollections;
        }
    }
}
