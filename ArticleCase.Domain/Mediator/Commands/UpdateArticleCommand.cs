﻿namespace ArticleCase.Domain.Mediator.Commands
{
    public class UpdateArticleCommand:IBaseRequest
    {
        public int Id { get; set; }
        public string ModelContent { get; }
        public string ModelDescription { get; }
        public int ModelLanguage { get; }
        public int Language { get; }
        public string ModelTitle { get; }
        public int ModelType { get; }
        public int ModelAuthorId { get; }
        public string ImageUrl { get; set; }

        public UpdateArticleCommand(string modelContent, string modelDescription, string modelImageUrl,
            in int modelLanguage, in int language, string modelTitle, in int modelType, in int modelAuthorId,in int id)
        {
            ModelContent = modelContent;
            ModelDescription = modelDescription;
            ModelLanguage = modelLanguage;
            Language = language;
            ModelTitle = modelTitle;
            ModelType = modelType;
            ModelAuthorId = modelAuthorId;
            Id = id;
            ImageUrl = modelImageUrl;
        }
    }
}