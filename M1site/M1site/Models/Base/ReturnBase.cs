using M1site.Enum;

namespace M1site.Models.Base
{
    public class ReturnBase
    {
        public ErrorEnum ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public string GetMessage(ErrorEnum errorEnum)
        {
            return errorEnum.ToString();
        }
    }
}
