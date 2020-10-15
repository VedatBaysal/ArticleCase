using System.Collections.Generic;
using System.Linq;
using ArticleCase.Core;
using ArticleCase.Infrastructure.Services.Interfaces;
using ArticleCase.Repository.Repositories.Interfaces;

namespace ArticleCase.Infrastructure.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public Author CreateAuthor(Author author)
        {
            var returned = _authorRepository.Add(author);
            _authorRepository.SaveChanges();
            return returned;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _authorRepository.GetQueryable().Where(x => !x.IsDeleted).AsEnumerable();
        }
    }
}