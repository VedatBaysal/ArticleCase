using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ArticleCase.Core
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime? PublishDate { get; set; }
        public Language Language { get; set; }
        public ArticleType Type { get; set; }
        public uint ReadCount { get; set; }
        [NotMapped] public bool IsPublished => PublishDate.HasValue;
    }
}