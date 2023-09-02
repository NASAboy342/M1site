using M1site.Models;

namespace M1site.Repository
{
    public interface IDataRepository
    {
        List<GetItemsResponse> GetItems();
    }
}
