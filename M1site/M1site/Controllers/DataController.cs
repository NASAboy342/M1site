using M1site.Enum;
using M1site.Models;
using M1site.Models.Base;
using M1site.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace M1site.Controllers
{
    [ApiController]
    [Route("Data")]
    public class DataController
    {
        private readonly IDataService _dataService;
        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }
        [HttpPost]
        [Route("test-connection")]
        public ReturnBase TestConnection()
        {
            try
            {
                return _dataService.TestConnection();
            }
            catch (Exception ex)
            {
                return new ReturnBase() { ErrorCode = ErrorEnum.Exeption, ErrorMessage = ex.ToString() };
            }
        }
        [HttpPost]
        [Route("m1-get-Items")]
        public BaseApiResponse<List<GetItemsResponse>> GetItems()
        {
            try
            {
                return new BaseApiResponse<List<GetItemsResponse>> { Data = _dataService.GetItems() };
            }
            catch(Exception ex)
            {
                return new BaseApiResponse<List<GetItemsResponse>> { ErrorCode = ErrorEnum.Exeption, ErrorMessage = ex.ToString() };

            }
        }
    }
}
