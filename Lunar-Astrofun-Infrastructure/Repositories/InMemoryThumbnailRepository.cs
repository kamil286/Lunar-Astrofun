using Lunar.Astrofun.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lunar.Astrofun.Infrastructure.Repositories
{
    public class InMemoryThumbnailRepository
    {
        public static ISet<Thumbnail> _thumbnail = new HashSet<Thumbnail>()
        {
            new Thumbnail("Mars", "Cosmos", "Mars is the one of the best planet"),
            new Thumbnail("Shopenchauer", "Literature", " ... "),
        };

        public void Add(Thumbnail thumbnail)
            => _thumbnail.Add(thumbnail);

        public Thumbnail Get(Guid id)
            => _thumbnail.Single(x => x.Id == id);

        public IEnumerable<Thumbnail> GetAll()
            => _thumbnail;

        public void Remove(Guid id)
        {
            var user = Get(id);
            _thumbnail.Remove(user);
        }

        public void Update(Thumbnail user) { }
    }
}
}
