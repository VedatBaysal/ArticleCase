using ArticleCase.Contract;
using MediatR;

namespace ArticleCase.Domain
{
    public interface IBaseRequestHandler<in T> : IRequestHandler<T, BaseResponseModel> where T : IRequest<BaseResponseModel>
    {
        
    }
}