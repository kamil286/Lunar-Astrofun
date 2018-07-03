using Lunar.Astrofun.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Core.Repositories
{
    public interface IThumbnailRepository: IBaseRepository<Thumbnail>
    {
        Thumbnail GetByTitle(string title);
    }
}
