﻿using System.Threading;
using System.Threading.Tasks;
using ArticleCase.Contract;
using ArticleCase.Core;
using ArticleCase.Domain.Mediator.Commands;
using ArticleCase.Infrastructure.Services.Interfaces;
using AutoMapper;

namespace ArticleCase.Domain.Mediator.Handlers.ArticleHandlers
{
    public class UpdateArticleCommandHandler:IBaseRequestHandler<UpdateArticleCommand>
    {
        private readonly IArticleService _articleService;
        private readonly IMapper _mapper;

        public UpdateArticleCommandHandler(IArticleService articleService, IMapper mapper)
        {
            _articleService = articleService;
            _mapper = mapper;
        }

        public Task<BaseResponseModel> Handle(UpdateArticleCommand request, CancellationToken cancellationToken)
        {
            _articleService.UpdateArticle(request.Id, article =>
            {
                article.Content = request.ModelContent;
                article.Description = request.ModelDescription;
                article.Content = request.ModelContent
            });
            //todo;
        }
    }
}