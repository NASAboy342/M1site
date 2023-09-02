using M1site.Models;
using M1site.Models.Base;
using M1site.Repository;

namespace M1site.Services
{
    public class DataService : IDataService
    {
        private readonly IDbHelper _dbHelper;
        private readonly IDataRepository _dataRepository;
        public DataService(IDbHelper dbHelper,IDataRepository dataRepository)
        {
            _dbHelper = dbHelper;
            _dataRepository = dataRepository;
        }

        public List<GetItemsResponse> GetItems()
        {
            return _dataRepository.GetItems();
        }

        public ReturnBase TestConnection()
        {
            return _dbHelper.TestConnection();
        }
    }
}
