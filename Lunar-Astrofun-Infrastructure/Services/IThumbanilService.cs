using Lunar.Astrofun.Infrastructure.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Infrastructure.Services
{
    public interface IThumbanilService
    {
        ThumbnailDto Get(Guid id);
        void Create(string title, string category, string content);
    }
}
