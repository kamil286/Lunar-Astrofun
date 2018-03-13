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

        public Thumbnail Get(Guid id)
            => _thumbnails.Single(x => x.Id == id);

        public IEnumerable<Thumbnail> GetAll()
            => _thumbnails;

        public void Remove(Guid id)
        {
            var thumbnail = Get(id);
            _thumbnails.Remove(thumbnail);
        }

        public void Update(Thumbnail user) { }
    }
}

