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
        public static IDbConnection Connection(DatabaseInfo databaseInfo)
        {
            switch (databaseInfo.DatabaseType)
            {
                case DatabaseTypeEnum.Mysql:
                    return new MySqlConnection($"Server={databaseInfo.IP};Port={databaseInfo.Port};Database={databaseInfo.DefaultDatabase};Uid={databaseInfo.Login};Pwd={databaseInfo.Pwd};");
                case DatabaseTypeEnum.SqlServer:
                    return new SqlConnection($"Server={databaseInfo.IP},{databaseInfo.Port};Database={databaseInfo.DefaultDatabase};User Id={databaseInfo.Login};Password={databaseInfo.Pwd};");
                default:
                    throw new NotSupportedException("不支持");
            }
        }
    }
}
