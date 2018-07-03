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
            Title = TitleValidator(title);
            Category = CategoryValidator(category);
            Content = ContentValidator(content);
            CreatedAt = DateTime.UtcNow;
        }

        private string TitleValidator(string title) {
            if (!string.IsNullOrEmpty(title) && char.IsUpper(title[0]))
            {
               return title;
            }
            else 
            {
                throw new Exception("Title cannot be empty and must start with uppercase !");
            }
        }

        private string CategoryValidator(string category) {
            if (!string.IsNullOrEmpty(category))
            {
               return category;
            }
            else 
            {
                throw new Exception("Category cannot be empty !");
            }
        }

        private string ContentValidator(string content) {
            if (!string.IsNullOrEmpty(content) && char.IsUpper(content[0]))
            {
               return content;
            }
            else 
            {
                throw new Exception("Content cannot be empty !");
            }
        }
    }
}
