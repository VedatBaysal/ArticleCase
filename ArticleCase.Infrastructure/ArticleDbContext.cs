using ArticleCase.Core;
using Microsoft.EntityFrameworkCore;

namespace ArticleCase.Infrastructure
{
    public class ArticleDbContext : DbContext
    {
        public ArticleDbContext(DbContextOptions<ArticleDbContext> options) : base(options)
        {
            
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}