using Lunar.Astrofun.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Core.Repositories
{
    public interface IThumbnailRepository
    {
        Thumbnail Get(Guid id);
        Thumbnail GetByTitle(string title);
        IEnumerable<Thumbnail> GetAll();
        void Add(Thumbnail thumbnail);
        void Update(Thumbnail thumbnail);
        void Remove(Guid id);
    }
}
