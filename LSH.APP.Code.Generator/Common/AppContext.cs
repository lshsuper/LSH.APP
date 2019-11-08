using LSH.APP.Code.Generator.Models;
using LSH.APP.Infrastructure.Helpers.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSH.APP.Code.Generator.Common
{
    public class AppContext
    {
        public static DatabaseConnectionOption DatabaseInfo { get; set; }
        public static TableInfoExt CurrentTable { get; set; }

        public static DatabaseInfoExt CurrentDatabase { get; set; }
    }
}
