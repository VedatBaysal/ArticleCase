using System;
using System.Threading;
using System.Threading.Tasks;
using ArticleCase.Contract;
using ArticleCase.Contract.Article;
using ArticleCase.Core;
using ArticleCase.Domain.Mediator.Commands;
using ArticleCase.Infrastructure.Services.Interfaces;
using AutoMapper;

namespace ArticleCase.Domain.Mediator.Handlers.ArticleHandlers
{
    public class UpdateArticleCommandHandler : IBaseRequestHandler<UpdateArticleCommand>
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public UpdateArticleCommandHandler(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public Task<BaseResponseModel> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            var updated = _articleService.UpdateArticle(request.Id, article =>
            {
                article.Content = request.ModelContent;
                article.Description = request.ModelDescription;
                article.AuthorId = request.ModelAuthorId;
                article.ImageUrl = request.ImageUrl;
                article.Language = (Language)request.Language;
                article.Type = (ArticleType)request.ModelType;
                article.Title = request.ModelTitle;
                article.UpdateDate = DateTime.Now;
            });
            if (updated == null)
            {
                return Task.FromResult(new BaseResponseModel
                {
                    Description = "Couldn't Update Article",
                    StatusCode = 400
                });
            }
            return Task.FromResult(new BaseResponseModel
            {
                Data = _mapper.Map<ArticleViewModel>(updated),
                Description = "Article is Updated",
                StatusCode = 200
            });
            //todo;
        }
    }
}