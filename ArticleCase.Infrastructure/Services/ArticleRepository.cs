using ArticleCase.Core;
using ArticleCase.Repository;
using ArticleCase.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArticleCase.Infrastructure.Services
{
    public class ArticleRepository : BaseRepository<Article>,IArticleRepository
    {
        public ArticleRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}