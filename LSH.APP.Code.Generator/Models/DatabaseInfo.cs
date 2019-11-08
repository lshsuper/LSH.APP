using LSH.APP.Code.Generator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Models
{
    public class DatabaseInfo
    {
        public  string Login { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
        public string Pwd { get; set; }
        public  DatabaseTypeEnum DatabaseType { get; set; }
        public    string DefaultDatabase { get; set; }

     
             
    }
}
