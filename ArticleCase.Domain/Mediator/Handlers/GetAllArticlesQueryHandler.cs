using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ArticleCase.Contract;
using ArticleCase.Contract.Article;
using ArticleCase.Domain.Mediator.Queries;
using ArticleCase.Infrastructure.Services.Interfaces;
using AutoMapper;

namespace ArticleCase.Domain.Mediator.Handlers
{
    public class GetAllArticlesQueryHandler : IBaseRequestHandler<GetAllArticlesQuery>
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper; 

        public GetAllArticlesQueryHandler(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public Task<BaseResponseModel> Handle(GetAllArticlesQuery request, CancellationToken cancellationToken)
        {
            var found = _articleService.GetAllArticles();
            return Task.FromResult(new BaseResponseModel
            {
                Data = _mapper.Map<IEnumerable<ArticleViewModel>>(found),
                Description = "Found articles",
                StatusCode = 200
            });
        }
    }
}