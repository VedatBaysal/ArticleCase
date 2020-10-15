using System;
using System.Collections.Generic;
using System.Linq;
using ArticleCase.Core;
using ArticleCase.Infrastructure.Services.Interfaces;
using ArticleCase.Repository;

namespace ArticleCase.Infrastructure.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IRepository<Article> _articleRepository;

        public ArticleService(IRepository<Article> articleRepository)
        {
            _articleRepository = articleRepository;
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return _articleRepository.GetQueryable().AsEnumerable();
        }

        public Article GetArticleById(int articleId)
        {
            return _articleRepository.GetById(articleId);
        }
        public Article CreateArticle(Article entity)
        {
            var returned = _articleRepository.Add(entity);
            _articleRepository.SaveChanges();

            return returned;
        }

        public Article UpdateArticle(int articleId, Action<Article> updateFunction)
        {
            var found = _articleRepository.GetById(articleId);
            if (found == null)
            {
                return null;
            }

            updateFunction(found);
            
            _articleRepository.Update(found);
            _articleRepository.SaveChanges();
            return found;
        }

        public bool DeleteArticle(int articleId)
        {
            var found = _articleRepository.GetById(articleId);
            if (found == null)
            {
                return false;
            }

            found.IsDeleted = true;

            _articleRepository.Update(found);
            _articleRepository.SaveChanges();
            return found.IsDeleted;
        }
    }
}