using System;

namespace ArticleCase.Contract.Author
{
    public class AuthorCreateModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}