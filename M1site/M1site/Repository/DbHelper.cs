using Dapper;
using M1site.Enum;
using M1site.Models.Base;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace M1site.Repository
{
    public class DbHelper : IDbHelper
    {
        private readonly IConfiguration _configuration;
        public DbHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbConnection OpentConnection()
        {
            var connectionString = _configuration.GetSection("ConnectionStrings").GetSection("NASA-DESKTOP").Value;
            return new SqlConnection(connectionString);
        }
        public IEnumerable<T> Query<T>( string storedProcedure, object param = null)
        {
            using (DbConnection opentConnection = OpentConnection())
            {
                return opentConnection.Query<T>(storedProcedure, param, null, true, 60, CommandType.StoredProcedure);
            }
        }
        public ReturnBase TestConnection()
        {
            using (DbConnection openConnection = OpentConnection())
            {
                openConnection.Open();
                if (openConnection.State != ConnectionState.Open)
                {
                    openConnection.Close();
                    return new ReturnBase { ErrorCode = ErrorEnum.ConnectionFail, ErrorMessage = ErrorEnum.ConnectionFail.ToString() };
                }
                openConnection.Close();
                return new ReturnBase { ErrorCode = ErrorEnum.Success, ErrorMessage = ErrorEnum.Success.ToString() };
            }
        }
    }
}
