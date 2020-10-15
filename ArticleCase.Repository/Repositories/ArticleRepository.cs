using ArticleCase.Core;
using ArticleCase.Repository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArticleCase.Repository.Repositories
{
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        public ArticleRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}