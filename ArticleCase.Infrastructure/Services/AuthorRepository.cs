using ArticleCase.Core;
using ArticleCase.Repository;
using ArticleCase.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArticleCase.Infrastructure.Services
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}