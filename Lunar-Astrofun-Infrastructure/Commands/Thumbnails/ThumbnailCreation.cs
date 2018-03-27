using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Infrastructure.Commands.Thumbnails
{
    public class ThumbnailCreation: ICommand
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
    }
}
