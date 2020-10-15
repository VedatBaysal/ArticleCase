using System;

namespace ArticleCase.Domain.Mediator.Commands
{
    public class CreateAuthorCommand : IBaseRequest
    {
        public string ModelFirstName { get; }
        public string ModelLastName { get; }
        public DateTime ModelBirthDate { get; }

        public CreateAuthorCommand(string modelFirstName, string modelLastName, in DateTime modelBirthDate)
        {
            ModelFirstName = modelFirstName;
            ModelLastName = modelLastName;
            ModelBirthDate = modelBirthDate;
        }
    }
}