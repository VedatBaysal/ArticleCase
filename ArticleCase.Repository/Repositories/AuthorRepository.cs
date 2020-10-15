using ArticleCase.Core;
using ArticleCase.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArticleCase.Repository.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}