using LSH.APP.Code.Generator.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Common
{
    public class DatabaseFactory
    {
        public static IDbConnection Connection(DatabaseConnectionOption option)
        {
            switch (option.DatabaseType)
            {
                case DatabaseTypeEnum.Mysql:
                    return new MySqlConnection(option.ConnStr);
                case DatabaseTypeEnum.SqlServer:
                    return new SqlConnection(option.ConnStr);
                default:
                    throw new NotSupportedException("不支持");
            }
        }
    }
}
