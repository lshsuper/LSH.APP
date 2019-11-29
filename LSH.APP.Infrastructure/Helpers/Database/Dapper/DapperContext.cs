
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using LSH.APP.Infrastructure.Helpers.Database;

namespace LSH.APP.Code.Generator.Common
{
  public class DapperContext
    {
        public static IEnumerable<T> Query<T>(DatabaseConnectionOption databaseInfo,string sql,object  param=null)
        {
            using (var  conn=DatabaseFactory.Connection(databaseInfo))
            {
               return  conn.Query<T>(sql,param);
            }
        }
        public static T Find<T>(DatabaseConnectionOption databaseInfo,string sql,object param=null)
        {
            using (var conn = DatabaseFactory.Connection(databaseInfo))
            {
                return conn.QueryFirstOrDefault<T>(sql,param);
            }
        }
        public static int Excute(DatabaseConnectionOption databaseInfo, string sql, object param = null)
        {
            using (var conn = DatabaseFactory.Connection(databaseInfo))
            {
                return conn.Execute(sql, param);
            }
        }
        public static T Scalar<T>(DatabaseConnectionOption databaseInfo, string sql, object param = null)
        {
            using (var conn = DatabaseFactory.Connection(databaseInfo))
            {
                return conn.ExecuteScalar<T>(sql, param);
            }
        }
    }
}
