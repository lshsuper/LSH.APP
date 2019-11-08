using LSH.APP.Code.Generator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Infrastructure.Helpers.Database
{
    public class DatabaseConnectionOption
    {
        public  string Login { get; set; }
        public string Server { get; set; }
        public string Port { get; set; }
        public string Pwd { get; set; }
        public  DatabaseTypeEnum DatabaseType { get; set; }
        public    string DefaultDatabase { get; set; }
        public   string ConnStr
        {
            get
            {
                switch (DatabaseType)
                {
                    case DatabaseTypeEnum.Mysql:
                        return $"Server={Server};Port={Port};Database={DefaultDatabase};Uid={Login};Pwd={Pwd};";
                    case DatabaseTypeEnum.SqlServer:
                        return $"Server={Server};Database={DefaultDatabase};User Id={Login};Password={Pwd};";
                    default:
                        return string.Empty;
                }
            }
        }


    }
}
