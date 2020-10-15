namespace ArticleCase.Contract.Article
{
    public class ArticleCreateModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int Language { get; set; }
        public int Type { get; set; }
    }
}