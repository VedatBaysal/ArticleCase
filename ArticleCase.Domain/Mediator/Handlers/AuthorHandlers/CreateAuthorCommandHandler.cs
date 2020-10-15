using System.Threading;
using System.Threading.Tasks;
using ArticleCase.Contract;
using ArticleCase.Contract.Author;
using ArticleCase.Core;
using ArticleCase.Domain.Mediator.Commands;
using ArticleCase.Infrastructure.Services.Interfaces;
using AutoMapper;

namespace ArticleCase.Domain.Mediator.Handlers.AuthorHandlers
{
    public class CreateAuthorCommandHandler : IBaseRequestHandler<CreateAuthorCommand>
    {
        private readonly IAuthorService _authorService;
        private readonly IMapper _mapper;

        public CreateAuthorCommandHandler(IMapper mapper, IAuthorService authorService)
        {
            _mapper = mapper;
            _authorService = authorService;
        }

        public Task<BaseResponseModel> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
        {
            var author = _authorService.CreateAuthor(new Author
            {
                BirthDate = request.ModelBirthDate,
                FirstName = request.ModelFirstName,
                LastName = request.ModelLastName,
            });

            return Task.FromResult(new BaseResponseModel
            {
                Data = _mapper.Map<AuthorViewModel>(author),
                Description = "Author created",
                StatusCode = 201
            });
        }
    }
}