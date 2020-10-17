using ArticleCase.Contract;
using ArticleCase.Contract.ArticleType;
using ArticleCase.Core;
using ArticleCase.Domain.Mediator.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArticleCase.Domain.Mediator.Handlers.ArticleTypesHandlers
{
    class GetAllArticleTypesQueryHandler : IBaseRequestHandler<GetAllArticleTypesQuery>
    {
        public Task<BaseResponseModel> Handle(GetAllArticleTypesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new BaseResponseModel
            {
                Data = GetAllArticleTypesViewModels(),
                Description = "Article Type list",
                StatusCode = 200
            });
        }
        private static IEnumerable<ArticleTypeViewModel> GetAllArticleTypesViewModels()
        {
            Type enumType = typeof(ArticleType);
            var values = Enum.GetValues(enumType);
            foreach (var item in values)
            {
                yield return new ArticleTypeViewModel
                {
                    Name = Enum.GetName(enumType, item),
                    Value = (int)item
                };
            }
        }
    }
}
