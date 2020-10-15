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
    public class CreateArticleCommandHandler : IBaseRequestHandler<CreateArticleCommand>
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public CreateArticleCommandHandler(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public Task<BaseResponseModel> Handle(CreateArticleCommand request, CancellationToken cancellationToken)
        {
            var article = _articleService.CreateArticle(new Article
            {
                Content = request.ModelContent,
                Description = request.ModelDescription,
                Language = (Language) request.Language,
                Title = request.ModelTitle,
                Type = (ArticleType) request.ModelType,
                AuthorId = request.ModelAuthorId,
                ImageUrl = request.ImageUrl
            });

            return Task.FromResult(new BaseResponseModel
            {
                Data = _mapper.Map<ArticleViewModel>(article),
                Description = "Article Added",
                StatusCode = 201
            });
        }
    }
}