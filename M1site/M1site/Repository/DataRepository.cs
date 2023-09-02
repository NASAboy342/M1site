using M1site.Models;
using M1site.SP;

namespace M1site.Repository
{
    public class DataRepository : IDataRepository
    {
        private readonly IDbHelper _dbHelper;
        public DataRepository(IDbHelper dbHelper)
        {
            _dbHelper = dbHelper;
        }
        public List<GetItemsResponse> GetItems()
        {
            return _dbHelper.Query<GetItemsResponse>(SpLookUp.GetItems, null).ToList();
        }
    }
}
