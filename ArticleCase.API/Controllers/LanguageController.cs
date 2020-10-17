using ArticleCase.API.Extensions;
using ArticleCase.Domain.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ArticleCase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LanguageController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LanguageController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLanguages()
        {
            var query = new GetAllLanguagesQuery();
            var response = await _mediator.Send(query);
            return response.ToActionResult();
        }
    }
}