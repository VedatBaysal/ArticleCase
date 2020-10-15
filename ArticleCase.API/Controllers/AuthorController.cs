using System.Threading.Tasks;
using ArticleCase.API.Extensions;
using ArticleCase.Contract.Author;
using ArticleCase.Domain.Mediator.Commands;
using ArticleCase.Domain.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ArticleCase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthor(AuthorCreateModel model)
        {
            var command = new CreateAuthorCommand(model.FirstName, model.LastName, model.BirthDate);
            var response = await _mediator.Send(command);
            return response.ToActionResult();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var query = new GetAllAuthorsQuery();
            var response = await _mediator.Send(query);
            return response.ToActionResult();
        }
    }
}