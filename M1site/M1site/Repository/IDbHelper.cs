using M1site.Models.Base;
using System.Data.Common;

namespace M1site.Repository
{
    public interface IDbHelper
    {
        DbConnection OpentConnection();
        IEnumerable<T> Query<T>(string storedProcedure, object param = null);
        ReturnBase TestConnection();
    }
}
