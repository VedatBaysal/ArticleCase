namespace ArticleCase.Domain.Mediator.Queries
{
    public class GetByIdArticleQuery:IBaseRequest
    {
        public int Id { get; set; }
        public GetByIdArticleQuery(int id)
        {
            Id = id;
        }
    }
}