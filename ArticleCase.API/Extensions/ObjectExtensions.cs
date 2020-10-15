using ArticleCase.Contract;
using Microsoft.AspNetCore.Mvc;

namespace ArticleCase.API.Extensions
{
    public static class ObjectExtensions
    {
        public static IActionResult ToActionResult(this BaseResponseModel baseResponseModel)
        {
            return new ObjectResult(baseResponseModel.Data)
            {
                StatusCode = baseResponseModel.StatusCode
            };
        }
    }
}