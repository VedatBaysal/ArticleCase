using ArticleCase.Contract.Article;
using ArticleCase.Core;
using AutoMapper;

namespace ArticleCase.Domain.Mappings
{
    public class ArticleMappingProfile : Profile
    {
        public ArticleMappingProfile()
        {
            CreateMap<Article, ArticleViewModel>()
                .ForMember(model => model.AuthorFullName,
                    expression => expression.MapFrom(article => article.Author.FullName));
        }
    }
}