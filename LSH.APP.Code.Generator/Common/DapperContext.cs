using LSH.APP.Code.Generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
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
    }
}
