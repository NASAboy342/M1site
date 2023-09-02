using M1site.Models;
using M1site.Models.Base;

namespace M1site.Services
{
    public interface IDataService
    {
        ReturnBase TestConnection();
        List<GetItemsResponse> GetItems();
    }
}
