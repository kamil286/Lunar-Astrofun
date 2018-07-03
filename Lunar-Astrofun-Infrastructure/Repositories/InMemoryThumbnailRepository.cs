using Lunar.Astrofun.Core.Domain;
using Lunar.Astrofun.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lunar.Astrofun.Infrastructure.Repositories
{
    public class InMemoryThumbnailRepository: IThumbnailRepository
    {
        public static ISet<Thumbnail> _thumbnails = new HashSet<Thumbnail>()
        {
            new Thumbnail(Guid.NewGuid(), "Mars", "Cosmos", "Mars is the one of the best planet."),
            new Thumbnail(Guid.NewGuid(), "Shopenchauer", "Literature", " Shophenchauer was one of the most famus authors."),
        };

        public void Add(Thumbnail thumbnail)
            => _thumbnails.Add(thumbnail);

        public Thumbnail GetById(Guid id)
            => _thumbnails.FirstOrDefault(x => x.Id.Equals(id));

        public Thumbnail GetByTitle(string title)
            => _thumbnails.FirstOrDefault(x => x.Title == title);

        public IEnumerable<Thumbnail> GetAll()
            => _thumbnails;

        public void Remove(Guid id)
        {
            var thumbnail = GetById(id);
            _thumbnails.Remove(thumbnail);
        }

        public void Update(Thumbnail user) { }
  }
}

