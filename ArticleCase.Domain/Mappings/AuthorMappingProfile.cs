using ArticleCase.Contract.Author;
using ArticleCase.Core;
using AutoMapper;

namespace ArticleCase.Domain.Mappings
{
    public class AuthorMappingProfile : Profile
    {
        public AuthorMappingProfile()
        {
            CreateMap<Author, AuthorViewModel>();
        }
    }
}