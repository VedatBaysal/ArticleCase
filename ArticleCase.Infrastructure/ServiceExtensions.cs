using ArticleCase.Infrastructure.Services;
using ArticleCase.Infrastructure.Services.Interfaces;
using ArticleCase.Repository.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ArticleCase.Infrastructure
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            return services;
        }
    }
}