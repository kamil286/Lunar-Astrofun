using Lunar.Astrofun.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Infrastructure.DTO
{
    public class ThumbnailDto
    {
        public Guid Id { get; protected set;}
        public string Title { get; protected set; }
        public string Category { get; protected set; }
        public string Content { get; protected set; }
        public string ImageUrl { get; protected set; }
        public Thumbnail CreatedBy { get; protected set; }
    }
}
