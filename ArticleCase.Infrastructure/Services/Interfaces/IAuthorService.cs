using System.Collections.Generic;
using ArticleCase.Core;

namespace ArticleCase.Infrastructure.Services.Interfaces
{
    public interface IAuthorService
    {
        Author CreateAuthor(Author author);
        IEnumerable<Author> GetAllAuthors();
    }
}