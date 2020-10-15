using System;

namespace ArticleCase.Contract.Article
{
    public class ArticleViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AuthorFullName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public DateTime? PublishDate { get; set; }
        public bool IsPublished { get; set; }
        public int Language { get; set; }
        public int Type { get; set; }
        public uint ReadCount { get; set; }
    }
}