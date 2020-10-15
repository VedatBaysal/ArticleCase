using System.Threading;
using System.Threading.Tasks;
using ArticleCase.Contract;
using ArticleCase.Contract.Article;
using ArticleCase.Domain.Mediator.Queries;
using ArticleCase.Infrastructure.Services.Interfaces;
using AutoMapper;

namespace ArticleCase.Domain.Mediator.Handlers.ArticleHandlers
{
    public class GetByIdQueryHandler : IBaseRequestHandler<GetByIdArticleQuery>
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public GetByIdQueryHandler(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public Task<BaseResponseModel> Handle(GetByIdArticleQuery request, CancellationToken cancellationToken)
        {
            var articleById = _articleService.GetArticleById(request.Id);

            return Task.FromResult(new BaseResponseModel
            {
                Data = _mapper.Map<ArticleViewModel>(articleById),
                Description = "Article",
                StatusCode = 200
            });
        }
    }
}