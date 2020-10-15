using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ArticleCase.Contract;
using ArticleCase.Contract.Author;
using ArticleCase.Domain.Mediator.Queries;
using ArticleCase.Infrastructure.Services.Interfaces;
using AutoMapper;

namespace ArticleCase.Domain.Mediator.Handlers.AuthorHandlers
{
    public class GetAllAuthorsQueryHandler : IBaseRequestHandler<GetAllAuthorsQuery>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public GetAllAuthorsQueryHandler(IAuthorService authorService, IMapper mapper)
        {
            _authorService = authorService;
            _mapper = mapper;
        }

        public Task<BaseResponseModel> Handle(GetAllAuthorsQuery request, CancellationToken cancellationToken)
        {
            var allAuthors = _authorService.GetAllAuthors();
            return Task.FromResult(new BaseResponseModel
            {
                Data = _mapper.Map<IEnumerable<AuthorViewModel>>(allAuthors),
                Description = "All Authors",
                StatusCode = 200
            });
        }
    }
}