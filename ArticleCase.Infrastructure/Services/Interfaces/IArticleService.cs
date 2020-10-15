using System;
using System.Collections.Generic;
using ArticleCase.Core;

namespace ArticleCase.Infrastructure.Services.Interfaces
{
    public interface IArticleService
    {
        IEnumerable<Article> GetAllArticles();
        Article GetArticleById(int articleId);
        Article CreateArticle(Article entity);
        Article UpdateArticle(int articleId, Action<Article> updateFunction);
        bool DeleteArticle(int articleId);
    }
}