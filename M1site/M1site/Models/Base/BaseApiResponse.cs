using M1site.Enum;
using Microsoft.AspNetCore.Mvc;

namespace M1site.Models.Base
{
    public class BaseApiResponse<T>
    {
        public ErrorEnum ErrorCode { get; set; } = ErrorEnum.Success;
        public string ErrorMessage { get; set; } = ErrorEnum.Success.ToString();
        public T Data { get; set; }
    }
}
