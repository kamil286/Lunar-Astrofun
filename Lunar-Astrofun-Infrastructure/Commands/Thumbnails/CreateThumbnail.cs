using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Infrastructure.Commands.Thumbnails
{
    public class CreateThumbnail: ICommand
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
    }
}
