namespace ArticleCase.Domain.Mediator.Commands
{
    public class DeleteArticleCommand:IBaseRequest
    {
        public int Id { get; set; }
        public DeleteArticleCommand(int id)
        {
            Id = id;
        }
    }
}