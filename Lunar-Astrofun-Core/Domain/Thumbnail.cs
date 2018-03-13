using System;
using System.Collections.Generic;
using System.Text;

namespace Lunar.Astrofun.Core.Domain
{
    public class Thumbnail
    {
        public Guid Id { get; protected set; }
        public string Title { get; protected set; }
        public string Category { get; protected set; }
        public string Content { get; protected set; }
        public string ImageUrl { get; protected set; }
        public User CreatedBy { get; protected set; }
        public DateTime CreatedAt { get; protected set; }

        protected Thumbnail() {}

        public Thumbnail (Guid id, string title, string category,
            string content)
        {
            Id = id = Guid.NewGuid();
            Title = title;
            Category = category;
            Content = content;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
