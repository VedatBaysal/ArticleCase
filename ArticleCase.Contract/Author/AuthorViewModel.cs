using System;

namespace ArticleCase.Contract.Author
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}