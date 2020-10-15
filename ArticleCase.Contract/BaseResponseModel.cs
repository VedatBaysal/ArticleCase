namespace ArticleCase.Contract
{
    public class BaseResponseModel
    {
        public object Data { get; set; }
        public int StatusCode { get; set; }
        public string Description { get; set; }
    }
}