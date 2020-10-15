using System.Threading;
using System.Threading.Tasks;
using ArticleCase.Contract;
using ArticleCase.Contract.Article;
using ArticleCase.Domain.Mediator.Commands;
using ArticleCase.Infrastructure.Services.Interfaces;
using AutoMapper;

namespace ArticleCase.Domain.Mediator.Handlers.ArticleHandlers
{
    public class DeleteArticleCommandHandler:IBaseRequestHandler<DeleteArticleCommand>
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public DeleteArticleCommandHandler(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public Task<BaseResponseModel> Handle(DeleteArticleCommand request, CancellationToken cancellationToken)
        {
            var deleteArticle = _articleService.DeleteArticle(request.Id);
            return Task.FromResult(new BaseResponseModel
            {
                Data = _mapper.Map<ArticleViewModel>(deleteArticle),
                Description = "Kayıt başarıyla silindi",
                StatusCode = 200
            });
        }
    }
}