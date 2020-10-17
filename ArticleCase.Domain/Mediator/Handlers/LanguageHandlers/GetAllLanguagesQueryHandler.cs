using ArticleCase.Contract;
using ArticleCase.Contract.Language;
using ArticleCase.Core;
using ArticleCase.Domain.Mediator.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ArticleCase.Domain.Mediator.Handlers.LanguageHandlers
{
    class GetAllLanguagesQueryHandler : IBaseRequestHandler<GetAllLanguagesQuery>
    {
        public Task<BaseResponseModel> Handle(GetAllLanguagesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new BaseResponseModel
            {
                Data = GetLanguageViewModels(),
                Description = "Language list",
                StatusCode = 200
            });
        }
        private static IEnumerable<LanguageViewModel> GetLanguageViewModels()
        {
            Type enumType = typeof(Language);
            var values = Enum.GetValues(enumType);
            foreach (var item in values)
            {
                yield return new LanguageViewModel
                {
                    Name = Enum.GetName(enumType, item),
                    Value = (int)item
                };
            }
        }
    }
}
