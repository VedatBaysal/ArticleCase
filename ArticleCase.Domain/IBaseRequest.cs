using ArticleCase.Contract;
using MediatR;

namespace ArticleCase.Domain
{
    public interface IBaseRequest : IRequest<BaseResponseModel>
    {
        
    }
}