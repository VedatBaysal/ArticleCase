using ArticleCase.API.Extensions;
using ArticleCase.Domain.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArticleCase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TypeController:ControllerBase
    {
        private readonly IMediator _mediator;

        public TypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticleTypes()
        {
            var query = new GetAllArticleTypesQuery();
            var response = await _mediator.Send(query);
            return response.ToActionResult();
        }
    }
}