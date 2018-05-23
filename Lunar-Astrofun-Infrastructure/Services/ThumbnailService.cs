using System;
using System.Collections.Generic;
using AutoMapper;
using Lunar.Astrofun.Core.Domain;
using Lunar.Astrofun.Core.Repositories;
using Lunar.Astrofun.Infrastructure.DTO;

namespace Lunar.Astrofun.Infrastructure.Services
{
    public class ThumbnailService : IThumbnailService
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
            Thumbnail thumbnail = _thumbnailRepository.Get(id);
            if (thumbnail != null)
            {
                throw new Exception($"Thumbnail with this id {id} already exist!");
            }

            thumbnail = new Thumbnail(id, title, category, content);
            _thumbnailRepository.Add(thumbnail);
        }

        public ThumbnailDto Get(Guid id)
        {
            Thumbnail thumbnail = _thumbnailRepository.Get(id);
            return _mapper.Map<Thumbnail, ThumbnailDto>(thumbnail);
        }

        public ThumbnailDto GetByTitle(string title)
        {
            Thumbnail thumbnail = _thumbnailRepository.GetByTitle(title);
            return _mapper.Map<Thumbnail, ThumbnailDto>(thumbnail);
        }
        IEnumerable<ThumbnailDto> IThumbnailService.GetAll()
        {
            IEnumerable<Thumbnail> thumbnails = _thumbnailRepository.GetAll();
            return _mapper.Map<IEnumerable<Thumbnail>, IEnumerable<ThumbnailDto>>(thumbnails);
        }
    }
}
