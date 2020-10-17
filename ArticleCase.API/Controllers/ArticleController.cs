using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArticleCase.API.Extensions;
using ArticleCase.Contract.Article;
using ArticleCase.Domain.Mediator.Commands;
using ArticleCase.Domain.Mediator.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ArticleCase.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ArticleController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArticleController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllArticles()
        {
            var query = new GetAllArticlesQuery();
            var response = await _mediator.Send(query);
            return response.ToActionResult();
        }

        [HttpPost]
        public async Task<IActionResult> CreateArticle(ArticleCreateModel model)
        {
            var command = new CreateArticleCommand(model.Content, model.Description, model.ImageUrl, model.Language,
                model.Language,
                model.Title, model.Type, model.AuthorId);
            var response = await _mediator.Send(command);
            return response.ToActionResult();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var command = new GetByIdArticleQuery(id);
            var response = await _mediator.Send(command);
            return response.ToActionResult();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticle(int id)
        {
            var command = new DeleteArticleCommand(id);
            var response =await _mediator.Send(command);
            return response.ToActionResult();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateArticle(int id, [FromBody]ArticleUpdateModel model)
        {
            var command = new UpdateArticleCommand(model.Content, model.Description, model.ImageUrl, model.Language, model.Title, model.Type, model.AuthorId, id);
            var response = await _mediator.Send(command);
            return response.ToActionResult();
        }
    }
}